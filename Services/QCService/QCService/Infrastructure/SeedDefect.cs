using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QCService.Models.L01;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using DSSType = System.Collections.Generic.Dictionary<string, string>;
using LDType = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>;
namespace QCService.Infrastructure
{
    public static class SeedDefect
    {
        private static readonly string vi = "vi";
        private static readonly string en = "en";
        private static string ToJson<T>(T t) => JsonConvert.SerializeObject(t);

        private static readonly LDType differentDefect = new LDType { new DSSType { { vi, "Lỗi khác" }, { en, "different defects" } } };

        public static Tuple<DefectLib[],HandlerDefectLib[], TimelineDefectLib[]> SeedFullLib()
        {
            using (StreamReader r = new StreamReader(@".\SQL\data.json", System.Text.Encoding.UTF8,true))
            {
                string json = r.ReadToEnd();
                JArray data = JsonConvert.DeserializeObject<JArray>(json);

                return new Tuple<DefectLib[], HandlerDefectLib[], TimelineDefectLib[]>(DefectLib(data),HandlerLib(data),TimelineLib(data));
            }
        }

        private static TimelineDefectLib[] TimelineLib(JArray data)
        {
            var timelines = data.SelectMany(x => x.Value<JArray>("Timeline")?.Select(d => d.Value<string>("en"))).Where(f => !string.IsNullOrWhiteSpace(f)).Distinct();

            var result = timelines.Select(x=>new TimelineDefectLib {
                Name = x,
                Description = x,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                Id = Guid.NewGuid()
            }).ToArray();
            return result;
        }

        private static HandlerDefectLib[] HandlerLib(JArray data)
        {
            var handlers = data.GroupBy(c => c.Value<string>("ZoneTypeId")).Select(x => new
            {
                ZoneTypeId = x.Key,
                Handlers = x.SelectMany(h => h.Value<JArray>("Handler")?.Select(d => d.Value<string>("en"))).Where(f => !string.IsNullOrWhiteSpace(f)).Distinct()
            });

            var result = handlers.SelectMany(x => x.Handlers.Select(h => new HandlerDefectLib
            {
                ZoneTypeId = Guid.Parse(x.ZoneTypeId),
                Name = h,
                Description = h,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                Id = Guid.NewGuid()
            }));

            return result.ToArray();
        }

        private static DefectLib[] DefectLib(JArray data)
        {
            var ds = data.Select(x => {
                var i = new DefectLib
                {
                    Id = Guid.NewGuid(),
                    Code = x.Value<string>("Code"),
                    ZoneTypeId = Guid.Parse(x.Value<string>("ZoneTypeId")),
                    DefectTypes = x.Value<JArray>("DefectTypes")?.Select(x=> new DSSType { { en, x.Value<string>(en) }, { vi, x.Value<string>(vi) } }).ToList(),
                    Reasons = x.Value<JArray>("Reasons")?.Select(x => new DSSType { { en, x.Value<string>(en) }, { vi, x.Value<string>(vi) } }).ToList(),
                    Solutions = x.Value<JArray>("Solutions")?.Select(x => new DSSType { { en, x.Value<string>(en) }, { vi, x.Value<string>(vi) } }).ToList(),
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                };
                i.Name = i.DefectTypes == null ? "Unkown" : string.Join('/', i.DefectTypes.Select(x=>x[en]));
                i.Description = i.Name;
                return i;
            }).ToArray();

           
            return ds;

        }

        //private static DefectLib[] DefectLib(JArray data)
        //{
        //    var ds = data.Select(x => {
        //        var i = new DefectLib
        //        {
        //            Id = Guid.NewGuid(),
        //            Code = x.Value<string>("Code"),
        //            ZoneTypeId = Guid.Parse(x.Value<string>("ZoneTypeId")),
        //            DefectTypes = x.Value<JArray>("DefectTypes")?.Select(d => d.Value<string>("en")).Where(d => d != null).ToList(),
        //            Reasons = x.Value<JArray>("Reasons")?.Select(d => d.Value<string>("en")).ToList(),
        //            Solutions = x.Value<JArray>("Solutions")?.Select(d => d.Value<string>("en")).ToList(),
        //            CreateDate = DateTime.Now,
        //            UpdateDate = DateTime.Now,
        //        };
        //        i.Name = i.DefectTypes == null ? "hello" : string.Join('/', i.DefectTypes);
        //        i.Description = i.DefectTypes == null ? "hello" : string.Join('/', i.DefectTypes);
        //        return i;
        //    }).ToArray();


        //    return ds;

        //}


    }
}