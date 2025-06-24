using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace TrayPassGen
{
    internal static class PasswordGenerator
    {
        private static readonly char[] Lower   = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private static readonly char[] Upper   = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static readonly char[] Digits  = "0123456789".ToCharArray();
        private static readonly char[] Special = "!@#$%^&*()-_=+[]{};:,.<>/?".ToCharArray();
        public static readonly char[] SafeSymbols = "_-+=!@#.".ToCharArray();

        public static string Generate(int length, bool lower, bool upper, bool digits, bool special, char[]? customSpecial = null)

        {
            if (length < 4) throw new ArgumentOutOfRangeException(nameof(length), "Минимум 4 символа.");

            var pool = new StringBuilder();
            if (lower) pool.Append(Lower);
            if (upper) pool.Append(Upper);
            if (digits) pool.Append(Digits);
            if (special)
                pool.Append(customSpecial ?? Special);

            if (pool.Length == 0)
                throw new InvalidOperationException("Не выбрано ни одного набора символов.");

            var result = new char[length];
            using var rng = RandomNumberGenerator.Create();
            var bytes = new byte[length];
            rng.GetBytes(bytes);

            for (int i = 0; i < length; i++)
            {
                result[i] = pool[bytes[i] % pool.Length];
            }

            EnsureAtLeastOne(result, lower, Lower, rng);
            EnsureAtLeastOne(result, upper, Upper, rng);
            EnsureAtLeastOne(result, digits, Digits, rng);
            EnsureAtLeastOne(result, special, customSpecial ?? Special, rng);

            return new string(result);
        }

        private static void EnsureAtLeastOne(char[] password, bool needed, char[] set, RandomNumberGenerator rng)
        {
            if (!needed) return;

            var posBytes = new byte[1];
            int pos;

            do
            {
                rng.GetBytes(posBytes);
                pos = posBytes[0] % password.Length;
            } while (set.Contains(password[pos]));

            rng.GetBytes(posBytes);
            password[pos] = set[posBytes[0] % set.Length];
        }
    }
}
