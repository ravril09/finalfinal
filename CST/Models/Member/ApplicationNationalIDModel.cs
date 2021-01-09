using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models.Member
{
    class ApplicationNationalIDModel
    {
        // Personal Details
        private static string sno;
        private static string sn;
        private static string fn;
        private static string mn;
        private static string gender;
        private static int age = 0;
        private static string cs;
        private static string birthdate;
        private static string pob;
        private static string cn;
        private static string religion;
        private static string nationality;
        private static string addressGlob;

        // Setter Personal Details

        public static void setSno(string Sno)
        {
            sno = Sno;
        }
        public static void setSn(string Surname)
        {
            sn = Surname;
        }
        public static void setFn(string firstname)
        {
            fn = firstname;
        }
        public static void setMn(string middlename)
        {
            mn = middlename;
        }
        public static void setGender(string gen)
        {
            gender = gen;
        }
        public static void setAge(int studAge)
        {
            age = studAge;
        }

        public static void setCivil(string civil)
        {
            cs = civil;
        }

        public static void setBd(string bd)
        {
            birthdate = bd;
        }

        public static void setPlaceofbirth(string place)
        {
            pob = place;
        }

        public static void setCn(string contact)
        {
            cn = contact;
        }

        public static void setRel(string rel)
        {
            religion = rel;
        }

        public static void setNat(string nat)
        {
            nationality = nat;
        }

        public static void setAddress(string address)
        {
            addressGlob = address;
        }

        // Getter Personal Detail

        public static string getSno()
        {
            return sno;
        }

        public static string getFn()
        {
            return fn;
        }

        public static string getMn()
        {
            return mn;
        }
        public static string getSn()
        {
            return sn;
        }


        public static string getGen()
        {
            return gender;
        }

        public static int getAge()
        {
            return age;
        }

        public static string getCivil()
        {
            return cs;
        }

        public static string getbirthdate()
        {
            return birthdate;
        }

        public static string getPob()
        {
            return pob;
        }

        public static string getCn()
        {
            return cn;
        }

        public static string getRel()
        {
            return religion;

        }

        public static string getNat()
        {
            return nationality;
        }

        public static string getAddress()
        {
            return addressGlob;
        }

        // Other Detail 

        private static string eduatt;
        private static string occ;
        private static string ann;
        private static string otskill;
        private static string dpspoken;
        private static string preno;
        private static string email;

        // Setter Other Detail

        public static void setEdu(string Educa)
        {
            eduatt = Educa;
        }
        public static void setOcc(string Occ)
        {
            occ = Occ;
        }
        public static void setAnn(string Annual)
        {
            ann = Annual;
        }
        public static void setOtskill(string Otherskill)
        {
            otskill = Otherskill;
        }
        public static void setDspoken(string Spoken)
        {
            dpspoken = Spoken;
        }
        public static void setPreno(string Precinct)
        {
            preno = Precinct;
        }
        public static void setEmail(string Email)
        {
            email = Email;
        }

        // Getter Other Skill


        public static string getEduc()
        {
            return eduatt;
        }

        public static string getOcc()
        {
            return occ;
        }

        public static string getAnnu()
        {
            return ann;
        }

        public static string getOther()
        {
            return otskill;
        }

        public static string getSpoken()
        {
            return dpspoken;
        }

        public static string getPre()
        {
            return preno;
        }

        public static string getEmail()
        {
            return email;
        }

        // Family Details

        private static string f1fn;
        private static string f1rel;
        private static string f1age;
        private static string f1occ;
        private static string f1income;
        private static string f2fn;
        private static string f2rel;
        private static string f2age;
        private static string f2occ;
        private static string f2income;
        private static string f3fn;
        private static string f3rel;
        private static string f3age;
        private static string f3occ;
        private static string f3income;
        private static string f4fn;
        private static string f4rel;
        private static string f4age;
        private static string f4occ;
        private static string f4income;
        private static string f5fn;
        private static string f5rel;
        private static string f5age;
        private static string f5occ;
        private static string f5income;

        // Setter Family Details

        // Childre 1
        public static void setF1fn(string fname)
        {
            f1fn = fname;
        }
        public static void setF1rel(string fname)
        {
            f1rel = fname;
        }
        public static void setF1age(string fname)
        {
            f1age = fname;
        }
        public static void setF1occ(string fname)
        {
            f1occ = fname;
        }
        public static void setF1income(string fname)
        {
            f1income = fname;
        }

        // Children 2

        public static void setF2fn(string fname)
        {
            f2fn = fname;
        }
        public static void setF2rel(string fname)
        {
            f2rel = fname;
        }
        public static void setF2age(string fname)
        {
            f2age = fname;
        }
        public static void setF2occ(string fname)
        {
            f2occ = fname;
        }
        public static void setF2income(string fname)
        {
            f2income = fname;
        }

        // Children 3

        public static void setF3fn(string fname)
        {
            f3fn = fname;
        }
        public static void setF3rel(string fname)
        {
            f3rel = fname;
        }
        public static void setF3age(string fname)
        {
            f3age = fname;
        }
        public static void setF3occ(string fname)
        {
            f3occ = fname;
        }
        public static void setF3income(string fname)
        {
            f3income = fname;
        }

        // Children 4

        public static void setF4fn(string fname)
        {
            f4fn = fname;
        }
        public static void setF4rel(string fname)
        {
            f4rel = fname;
        }
        public static void setF4age(string fname)
        {
            f4age = fname;
        }
        public static void setF4occ(string fname)
        {
            f4occ = fname;
        }
        public static void setF4income(string fname)
        {
            f4income = fname;
        }

        // Children 5

        public static void setF5fn(string fname)
        {
            f5fn = fname;
        }
        public static void setF5rel(string fname)
        {
            f5rel = fname;
        }
        public static void setF5age(string fname)
        {
            f5age = fname;
        }
        public static void setF5occ(string fname)
        {
            f5occ = fname;
        }
        public static void setF5income(string fname)
        {
            f5income = fname;
        }

        public static void clearAll()
        {
            sno = "";
            fn = "";
            sn = "";
            mn = "";
            gender = "";
            age = 0;
            birthdate = "";
            pob = "";
            cn = "";
            religion = "";
            nationality = "";
            addressGlob = "";

            eduatt = "";
            occ = "";
            ann = "";
            otskill = "";
            dpspoken = "";
            preno = "";
            email = "";

            f1fn = "";
            f1rel = "";
            f1age = "";
            f1occ = "";
            f1income = "";

            f2fn = "";
            f2rel = "";
            f2age = "";
            f2occ = "";
            f2income = "";

            f3fn = "";
            f3rel = "";
            f3age = "";
            f3occ = "";
            f3income = "";

            f4fn = "";
            f4rel = "";
            f4age = "";
            f4occ = "";
            f4income = "";

            f5fn = "";
            f5rel = "";
            f5age = "";
            f5occ = "";
            f5income = "";
        }
    }
}
