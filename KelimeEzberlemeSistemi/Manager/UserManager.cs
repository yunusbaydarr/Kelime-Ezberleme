using KelimeEzberlemeSistemi.Context;
using KelimeEzberlemeSistemi.Model;

namespace KelimeEzberlemeSistemi.Manager
{
    public class UserManager
    {

        private readonly EfContext context;

        public UserManager()
        {
            context = new EfContext();
        }
        public bool KullaniciKayitEt(User user)
        {
            try
            {
                context.Users.Add(user);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }

        public bool SifremiDegistir(User user)
        {
            var _user = context.Users.FirstOrDefault(t => t.KullaniciAdi == user.KullaniciAdi
            && user.SifreSorusu == t.SifreSorusu && t.SifreCevabi == user.SifreCevabi
            );

            if (_user != null)
            {
                try
                {
                    _user.Sifre = user.Sifre;
                    context.Update(_user);
                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                return false;
            }


        }

        public User GirisYap(User user)
        {
            var _user = context.Users.FirstOrDefault(t => t.KullaniciAdi == user.KullaniciAdi && t.Sifre == user.Sifre);
            if (_user != null)
            {
                return _user;
            }
            else
            {
                return null;
            }

        }

    }
}
