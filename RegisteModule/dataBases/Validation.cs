using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegisteModule.dataBases
{
    class Validation
    {
        public bool isVildEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromSeconds(200));
                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }catch(RegexMatchTimeoutException e)
            {
                return false;
            }catch(ArgumentException e)
            {
                return false;
            }
            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromSeconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public bool verification(string Name, string Login, string Email, string Pass, string rePass, string Sector, string Level)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Login) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Pass) || string.IsNullOrWhiteSpace(rePass) || string.IsNullOrWhiteSpace(Sector) || string.IsNullOrWhiteSpace(Level))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
