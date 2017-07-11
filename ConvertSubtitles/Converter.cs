using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ConvertSubtitles
{
    public static class Converter
    {
        public static void ConverterVttToSrt(string path)
        {
            var subs = File.ReadAllLines(path);
            var newSub = new List<string>();
            var num = 1;
            for (var i = 0; i < subs.Length; i++)
            {
                if (i < 2)
                {
                    continue;
                }

                if (Regex.IsMatch(subs[i],
                    "^[0-9]{2}[:]{1}[0-9]{2}[:]{1}[0-9]{2}[.]{1}[0-9]{3} [-]{2}[>]{1} [0-9]{2}[:]{1}[0-9]{2}[:]{1}[0-9]{2}[.]{1}[0-9]{3}$"))
                {
                    newSub.Add($"{num}");
                    num++;
                    subs[i] = subs[i].Replace(".", ",");
                }
                newSub.Add(subs[i]);
            }
            File.WriteAllLines(path.Replace(".vtt", ".srt"), newSub);
        }
    }
}