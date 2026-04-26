using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP_MODUL9_103022400147
{
    internal class CovidConfig
    {
        public string satuan_suhu { get; set; }
        public int batas_hari_demam { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        public static CovidConfig Load()
        {
            string path = "covid_config.json";

            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<CovidConfig>(json);
        }

        public void UbahSatuan()
        {
            if (satuan_suhu == "celcius")
                satuan_suhu = "fahrenheit";
            else
                satuan_suhu = "celcius";
        }
    }
}
