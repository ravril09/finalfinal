using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models.Student
{
    class SeniorModel
    {
        //Detailes
        private static string sno;
        private static string fn;
        private static string ln;
        private static string mn;
        private static string Ctel_no;
        private static string gender;
        private static int age = 0;
        private static string cs;
        private static string birthdate;
        private static string pob;
        private static string cn;
        private static string religion;
        private static string nationality;
        private static string addressGlob;

        //setter Details
        public static void setFn(string firstname)
        {
            fn = firstname;
        }

        public static void setLn(string lastname)
        {
            ln = lastname;
        }

        public static void setSno(string studno)
        {
            sno = studno;
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

        //getter Details

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
        public static string getLn()
        {
            return ln;
        }

        public static string getCont()
        {
            return Ctel_no;
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


        //Children Details

        private static string children1_name;
        private static string children1_no;
        private static string children1_add;

        private static string children2_name;
        private static string children2_no;
        private static string children2_add;

        private static string children3_name;
        private static string children3_no;
        private static string children3_add;


        private static string Emer_name;
        private static string Emer_add;
        private static string Emer_relation;
        private static string Emer_no;

        private static string parent_status;


        // Children 1
        public static void setChildren1_name(string name)
        {
            children1_name = name;
        }


        public static void setChildren1_no(string name)
        {
            children1_no = name;
        }



        public static void setChildren1_add(string name)
        {
            children1_add = name;
        }



        // Children 2
        public static void setChildren2_name(string name)
        {
            children2_name = name;
        }


        public static void setChildren2_no(string name)
        {
            children2_no = name;
        }



        public static void setChildren2_add(string name)
        {
            children2_add = name;
        }

        // Children 3

        public static void setChildren3_name(string name)
        {
            children3_name = name;
        }


        public static void setChildren3_no(string name)
        {
            children3_no = name;
        }



        public static void setChildren3_add(string name)
        {
            children3_add = name;
        }



        public static void setEmer_name(string name)
        {
            Emer_name = name;
        }
        public static void setEmer_add(string name)
        {
            Emer_add = name;
        }
        public static void setEmer_rel(string name)
        {
            Emer_relation = name;
        }
        public static void setEmer_no(string name)
        {
            Emer_no = name;
        }




        //getter for Children Details
        public static string getChildren1_name()
        {
            return children1_name;
        }

        public static string getChildren1_no()
        {
            return children1_no;
        }


        public static string getChildren1_add()
        {
            return children1_add;
        }

        public static string getChildren2_name()
        {
            return children2_name;
        }

        public static string getChildren2_no()
        {
            return children2_no;
        }


        public static string getChildren2_add()
        {
            return children2_add;
        }


        public static string getChildren3_name()
        {
            return children3_name;
        }

        public static string getChildren3_no()
        {
            return children3_no;
        }


        public static string getChildren3_add()
        {
            return children3_add;
        }

        public static string getEmer_name()
        {
            return Emer_name;
        }
        public static string getEmer_add()
        {
            return Emer_add;
        }
        public static string getEmer_rel()
        {
            return Emer_relation;
        }
        public static string getEmer_no()
        {
            return Emer_no;
        }

        // Identification Number


        private static string osca;
        private static string tin;
        private static string philhealth;
        private static string gsis;
        private static string sss;

        private static string memship;
        private static string monthly;

        // setter for Identification Number

        public static void setOSCA(string number)
        {
            osca = number;
        }

        public static void setTin(string number)
        {
            tin = number;
        }

        public static void setPhil(string number)
        {
            philhealth = number;
        }

        public static void setGSIS(string number)
        {
            gsis = number;
        }

        public static void setSSS(string number)
        {
            sss = number;
        }

        public static void setMemship(string number)
        {
            memship = number;
        }

        public static void setMonthly(string number)
        {
            monthly = number;
        }
        // getter for Identification Number

        public static string getOSCA()
        {
            return osca;
        }

        public static string getTin()
        {
            return tin;
        }

        public static string getPhil()
        {
            return philhealth;
        }

        public static string getGSIS()
        {
            return gsis;
        }

        public static string getSSS()
        {
            return sss;
        }


        public static string getMemship()
        {
            return memship;
        }

        public static string getMonthly()
        {
            return monthly;
        }



        public static void clearAll()
        {
            sno = "";
            fn = "";
            ln = "";
            mn = "";
            gender = "";
            age = 0;
            birthdate = "";
            pob = "";
            cn = "";
            religion = "";
            nationality = "";
            addressGlob = "";

            children1_name = "";
            children1_no = "";
            children1_add = "";
           
            children2_name = "";
            children2_no = "";
            children2_add = "";

            children3_name = "";
            children3_no= "";
            children3_add = "";

            Emer_name = "";
            Emer_add = "";
            Emer_relation = "";
            Emer_no = "";

            osca = "";
            tin = "";
            philhealth = "";
            gsis = "";
            sss = "";

            memship = "";
            monthly = "";
            
    }

    }
}
