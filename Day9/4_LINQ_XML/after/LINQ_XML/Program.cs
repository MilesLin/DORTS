﻿using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LINQ_XML
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 請印出學號是 9096007 的資料
            string xml = GetXML();

            /*
                使用 LINQ to XML
             */
            XElement xmlFile = XElement.Parse(xml);
            var result = xmlFile.Elements()
                .Where(x => (string)x.Element("學號") == "9096007")
                .Select(x => new
                {
                    學號 = (string)x.Element("學號"),
                    姓名 = (string)x.Element("姓名")
                })
                .FirstOrDefault();

            System.Console.WriteLine($"{result.姓名}: {result.學號}");

            /*
                使用序列化 XML 的方式
             */
            XmlSerializer deserializer = new XmlSerializer(typeof(Person));
            using (TextReader reader = new StringReader(xml))
            {
                object deserializationObj = deserializer.Deserialize(reader);

                var p = deserializationObj as Person;

                var pResult = p.學生.Where(x => x.學號 == 9096007).FirstOrDefault();
                System.Console.WriteLine($"{pResult.姓名}: {pResult.學號}");

            };
        }

        private static string GetXML()
        {
            return @"<?xml version=""1.0"" encoding=""utf-8""?>
                    <Person>
                      <學生>
                        <學號>9096036</學號>
                        <姓名>蔡文龍</姓名>
                        <電話>04-32345671</電話>
                        <信箱>wltasi@yahoo.com.tw</信箱>
                      </學生>
                      <學生>
                        <學號>9096001</學號>
                        <姓名>許百宏</姓名>
                        <電話>04-12345671</電話>
                        <信箱>em@ms37.hient.net</信箱>
                      </學生>
                      <學生>
                        <學號>9096002</學號>
                        <姓名>林宜美</姓名>
                        <電話>04-78955671</電話>
                        <信箱>em@ms37.yam.net</信箱>
                      </學生>
                      <學生>
                        <學號>9096003</學號>
                        <姓名>賴玲英</姓名>
                        <電話>049-6345671</電話>
                        <信箱>pc@ms56.hient.net</信箱>
                      </學生>
                      <學生>
                        <學號>9096004</學號>
                        <姓名>丁勝勇</姓名>
                        <電話>02-12344471</電話>
                        <信箱>em@ms37.hient.seed.tw</信箱>
                      </學生>
                      <學生>
                        <學號>9096005</學號>
                        <姓名>劉曉珍</姓名>
                        <電話>049-1345671</電話>
                        <信箱>yy@ms45.hient.net</信箱>
                      </學生>
                      <學生>
                        <學號>9096006</學號>
                        <姓名>李逢源</姓名>
                        <電話>06-11235671</電話>
                        <信箱>et@ms37.yam.net</信箱>
                      </學生>
                      <學生>
                        <學號>9096007</學號>
                        <姓名>卓水信</姓名>
                        <電話>02-17896671</電話>
                        <信箱>em@ms37.pchome.net</信箱>
                      </學生>
                      <學生>
                        <學號>9096008</學號>
                        <姓名>謝沂臻</姓名>
                        <電話>049-1234571</電話>
                        <信箱>em@ms56.pchome.net</信箱>
                      </學生>
                      <學生>
                        <學號>9096009</學號>
                        <姓名>徐志宏</姓名>
                        <電話>04-15465671</電話>
                        <信箱>pp@ms69.hient.net</信箱>
                      </學生>
                      <學生>
                        <學號>9096010</學號>
                        <姓名>吳廣信</姓名>
                        <電話>04-12349999</電話>
                        <信箱>em@ms37.yahoo.net</信箱>
                      </學生>
                      <學生>
                        <學號>9096011</學號>
                        <姓名>王富民</姓名>
                        <電話>049-1478523</電話>
                        <信箱>em@ms69.hient.net</信箱>
                      </學生>
                      <學生>
                        <學號>9096012</學號>
                        <姓名>蔡佳諠</姓名>
                        <電話>04-78965671</電話>
                        <信箱>yy@ms69.pchome.net</信箱>
                      </學生>
                      <學生>
                        <學號>9096013</學號>
                        <姓名>陳姿伶</姓名>
                        <電話>04-65475671</電話>
                        <信箱>em@ms69.hient.net.tw</信箱>
                      </學生>
                      <學生>
                        <學號>9096014</學號>
                        <姓名>林宜慧</姓名>
                        <電話>06-2345671</電話>
                        <信箱>em@ms11.hient.net</信箱>
                      </學生>
                      <學生>
                        <學號>9096015</學號>
                        <姓名>黃其政</姓名>
                        <電話>04-545555671</電話>
                        <信箱>em@ms69.hient.net</信箱>
                      </學生>
                    </Person>";
        }
    }
}