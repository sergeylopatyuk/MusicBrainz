﻿namespace Hqub.MusicBrainz.Client
{
    public static class Extensions
    {
        public static string ToShortDate(this string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 4)
            {
                return "----";
            }

            return s.Substring(0, 4);
        }
    }
}
