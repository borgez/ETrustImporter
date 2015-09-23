using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace e_trust
{
    public class ETrust : АккредитованныеУдостоверяющиеЦентры
    {
        public string Url = "http://e-trust.gosuslugi.ru/CA/DownloadTSL?schemaVersion=0";
        public int total = 0;

        public ETrust(string url = null)
        {
            if (url == null)
                url = Url;
            using (var reader = XmlReader.Create(url))
            {
                var serializer = new XmlSerializer(typeof(АккредитованныеУдостоверяющиеЦентры));
                var ауц = (АккредитованныеУдостоверяющиеЦентры)serializer.Deserialize(reader);
                Версия = ауц.Версия;
                Дата = ауц.Дата;
                УдостоверяющийЦентр = ауц.УдостоверяющийЦентр;
            }
            Console.WriteLine("Загрузил свежие списки.");
            WriteRoot();
        }

        private void Write(IEnumerable<ДанныеСертификатаТип> certs, StoreName storename = StoreName.AuthRoot)
        {
            var store = new X509Store(storename, StoreLocation.CurrentUser);
            Import(store, certs);
        }


        private void Write(IEnumerable<ДанныеСертификатаТип> certs, string storename)
        {
            var store = new X509Store(storename, StoreLocation.CurrentUser);
            Import(store, certs);
        }

        private void Import(X509Store store, IEnumerable<ДанныеСертификатаТип> certs)
        {
            store.Open(OpenFlags.ReadWrite);
            var i = 0;
            var данныеСертификатаТипs = certs as ДанныеСертификатаТип[] ?? certs.ToArray();

            Console.WriteLine("Выбранных сертификатов {0}", данныеСертификатаТипs.Count());
            foreach (var cert in данныеСертификатаТипs.Where(cert => store.Certificates.Find(X509FindType.FindBySerialNumber, cert.СерийныйНомер, false).Count == 0))
            {
                Console.WriteLine("{0} {1} {2:d}-{3:d}", ++i, cert.СерийныйНомер, cert.ПериодДействияС, cert.ПериодДействияДо);
                store.Add(new X509Certificate2(cert.Данные));
            }
            total += i;

            Console.WriteLine("Импортировали новых {0}", i);
            store.Close();
        }

        private void WriteRoot()
        {
            var certs = УдостоверяющийЦентр
                .Where(w => w.ЭлектроннаяПочта.Contains("minsvyaz.ru"))
                .Where(w => w.СтатусАккредитации.Статус == СтатусАккредитацииТипСтатус.Действует)
                .SelectMany(s => s.ПрограммноАппаратныеКомплексы)
                .ToArray();

            var root = certs
                .Where(w => w.Псевдоним == "Головной удостоверяющий центр")
                .SelectMany(s1 => s1.КлючиУполномоченныхЛиц.SelectMany(s2 => s2.Сертификаты));

            var intermediate = certs
                .Where(w => w.Псевдоним != "Головной удостоверяющий центр")
                .SelectMany(s1 => s1.КлючиУполномоченныхЛиц.SelectMany(s2 => s2.Сертификаты));

            Write(root, StoreName.Root);
            Write(intermediate, "CA");
        }

        public void WriteIntermediates(bool onlyActive = true)
        {
            var certs = УдостоверяющийЦентр
                .Where(w => !w.ЭлектроннаяПочта.Contains("minsvyaz.ru"))
                .Where(w => w.СтатусАккредитации.Статус == СтатусАккредитацииТипСтатус.Действует)
                .SelectMany(s => s.ПрограммноАппаратныеКомплексы.SelectMany(s1 => s1.КлючиУполномоченныхЛиц.SelectMany(s2 => s2.Сертификаты)));
            if (onlyActive)
                certs = certs.Where(w => w.ПериодДействияДо >= DateTime.Now);
            Write(certs, "CA");
        }
    }
}
