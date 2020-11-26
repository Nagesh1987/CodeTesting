using AutoMapper;
using DemoLib1;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyDemo
{

    public class Dummy
    {
        public dynamic GetMemberUploadModelfromDataset()
        {
            return "dummy";
        }
    }

    public class AuthorModel
    {
        public int Id
        {
            get; set;
        }
        public String Firstname
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public string Address
        {
            get; set;
        }

        public List<obj1> permissions { get; set; }

    }

    public class AuthorViewModel
    {
        public int Id
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }
        public List<obj2> permissions { get; set; }
    }

    public class obj1
    {
        public string objName { get; set; }
    }

    public class obj2
    {
        public string objName { get; set; }
    }


    class AppPermissions
    {
        string NameofStudent { get; set; }
        public const string SchoolProfile = "SchoolProfile";
        public const string Dashboard = "Dashboard";

        public const string SchoolProfile_Create = "SchoolProfile.Create";
        public const string SchoolProfile_View = "SchoolProfile.Create";
        public const string SchoolProfile_Edit = "SchoolProfile.Edit";

        public const string Dashboard_View = "Dashboard.View";
    }

    public class Program
    {

        //AppPermissions appPermissions = new AppPermissions();
        //public class Class1
        //{
        //    internal protected string Name { get; set; }
        //}

        //public class Class2 : Class1
        //{
        //    public void somemethod()
        //    {
        //        Name = "nagesh";
        //        Console.WriteLine(Name);
        //    }
        //}

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public WeekDay bornweek { get; set; }
        }

        public enum WeekDay
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }

        static void Main(string[] args)
        {
            #region commented
            //Console.WriteLine("Day of week {0} {1}", (int)WeekDay.Sunday, WeekDay.Friday);
            //Console.WriteLine("Day of week {0} {1}", (int)WeekDay.Monday, WeekDay.Monday);
            //Console.WriteLine("Day of week {0} {1}", (int)WeekDay.Tuesday, WeekDay.Tuesday);
            //Console.WriteLine("Day of week {0} {1}", (int)WeekDay.Wednesday, WeekDay.Wednesday);
            //Console.WriteLine("Day of week {0} {1}", (int)WeekDay.Thursday, WeekDay.Thursday);
            //Console.WriteLine("Day of week {0} {1}", (int)WeekDay.Friday, WeekDay.Friday);
            //Console.WriteLine("Day of week {0} {1}", (int)WeekDay.Saturday, WeekDay.Saturday);


            //Person person = new Person()
            //{
            //    Name = "Nagesh",
            //    Age = 16,
            //    bornweek = WeekDay.Sunday
            //};

            //Console.WriteLine("hi" + person.bornweek.ToString());

            //switch (person.bornweek)
            //{
            //    case WeekDay.Sunday:
            //        var something = "sunday born";
            //        Console.WriteLine(something);
            //        break;
            //}

            //List<string> weeks = new List<string>();
            //var en = Enum.GetNames(typeof(WeekDay));
            //weeks.AddRange(en);

            //Console.WriteLine("Day of  born week {0}", person.bornweek.ToString());

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(RandomPassword.Generate(8, 10));
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            // Class2 objclass2 = new Class2();

            //var config = new MapperConfiguration(cfg => { });

            //IMapper iMapper = config.CreateMapper();

            //var source = new AuthorModel
            //{
            //    Id = 1,

            //    Firstname = "Joydip",

            //    Address = "Address1",

            //    LastName = "Kanjilal",

            //    permissions = new List<obj1>() { new obj1() { objName = "name1" }, new obj1() { objName = "name2" } }

            //};

            //var destination = iMapper.Map<AuthorViewModel>(source);

            //Console.WriteLine("Author Name: " + destination.FirstName + " permission=" + destination.permissions[0]);

            //var source1 = new obj1
            //{
            //    objName = "name1"
            //};

            //var destination1 = iMapper.Map<obj2>(source1);

            //Console.WriteLine("Author Name: " + destination1.objName);

            //Subject subject = new Subject();
            //// Observer1 takes a subscription to the store
            //Observer observer1 = new Observer("Observer 1");
            //subject.Subscribe(observer1);
            //// Observer2 also subscribes to the store
            //subject.Subscribe(new Observer("Observer 2"));
            //subject.Inventory++;
            //// Observer1 unsubscribes and Observer3 subscribes to notifications.
            //subject.Unsubscribe(observer1);
            //subject.Subscribe(new Observer("Observer 3"));
            //subject.Inventory++;

            //Uri uri = new Uri("https://portal.brightskool.com");
            //Uri uri = new Uri("https://edujournaltenant.cloudapp.net/");

            //string uri1 = string.Format("{0}://{1}.{2}", uri.Scheme, "matha", uri.Authority);
            //List<string> strlist = new List<string> { "item1", "item2" };

            //object t = "23:59:59.9999999";
            //TimeSpan time = new TimeSpan();
            //TimeSpan.TryParse(t.ToString(), out time);

            //Console.WriteLine(time);


            //Console.WriteLine(time.Hours);

            //string item = "Hi ";
            //Console.Write(item.TrimEnd());
            //Console.Write(item.TrimEnd());
            //var h = (string)null;
            //Console.Write(h.ToString());
            //Console.ReadLine();


            //AppPermissions time = new AppPermissions();
            //Type type = time.GetType();
            //Console.WriteLine(type);
            //foreach (FieldInfo property in type.GetFields().ToList().Where(item=>item.Name.Contains("School")))
            //{
            //    Console.WriteLine(property.Name);
            //}


            //string day = "Sunday";
            //DateTime fdate = Convert.ToDateTime("04/11/2019");

            //if (!Enum.IsDefined(typeof(DayOfWeek), day))
            //{
            //    string failurereason = "Invalid sessionDay";
            //}

            ////DateTime sdate = DateTime.Now.AddDays(-1);
            //DateTime sdate = Convert.ToDateTime("04/10/2019"); 
            //TimeSpan ts = fdate - sdate;
            //var sessions = ((ts.TotalDays / 7) + (sdate.DayOfWeek == DayOfWeek.Sunday || fdate.DayOfWeek == DayOfWeek.Sunday || fdate.DayOfWeek > sdate.DayOfWeek ? 1 : 0));
            //sessions = Math.Round(sessions - .5, MidpointRounding.AwayFromZero);

            //DateTime start = new DateTime(2019, 4, 10);
            //DateTime end = new DateTime(2019, 4, 22);

            //while (start.DayOfWeek.ToString() != DayOfWeek.Monday.ToString())
            //{
            //    start = start.AddDays(1);
            //}
            //while (end.DayOfWeek.ToString() != DayOfWeek.Monday.ToString())
            //{
            //    end = end.AddDays(-1);
            //}
            //int mondays = start > end ? 0 : (int)((end - start).TotalDays) / 7 + 1;
            #endregion

            //try
            //{

            //    byte[] bytes = { 0, 0, 0, 0, 0, 0, 0, 0 };

            //    var id1 = new Guid(784764576, 32767, 21452, bytes);

            //    //var id2 = new Guid(2, 2, 0, bytes);
            //    //var id3 = new Guid(3, 3, 0, bytes);
            //    //var id4 = new Guid(4, 4, 0, bytes);
            //    //var id5 = new Guid(5, 5, 0, bytes);

            //    Console.WriteLine("generated guid={0}", id1.ToString());

            //    //Console.WriteLine("generated guid={0}", id2.ToString());
            //    //Console.WriteLine("generated guid={0}", id3.ToString());
            //    //Console.WriteLine("generated guid={0}", id4.ToString());
            //    //Console.WriteLine("generated guid={0}", id5.ToString());

            //    var split = id1.ToString().Split('-');

            //    var First = BitConverter.ToInt32(id1.ToByteArray(), 0);

            //    var second = BitConverter.ToInt16(id1.ToByteArray(), 4);

            //    var third = BitConverter.ToInt16(id1.ToByteArray(), 6);


            //    Console.WriteLine(First);

            //    Console.WriteLine(second);

            //    Console.WriteLine(third);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Dummy dummy = new Dummy();
            //var something = (string)dummy.GetMemberUploadModelfromDataset();
            //Console.WriteLine(something.ToUpper());

            //DataTable dt = new DataTable();
            //dt.Columns.Add("id");
            //dt.Columns.Add("value");
            //dt.Rows.Add("1", "hi");
            //dt.Rows.Add("2", "bye");
            //dt.Rows.Add("3", "hello");

            //string json = new JObject(
            //    dt.Columns.Cast<DataColumn>()
            //      .Select(c => new JProperty(c.ColumnName, dt.Rows.Cast<DataRow>().Select(r=>r.Field<string>(c))))
            //).ToString(Formatting.None);

            string dumm = "hr.medicare.sg/hr";

            Console.WriteLine(dumm??"emptty");
            Console.WriteLine("hi");

            dumm.Replace("/hr", "/member");
            Console.WriteLine(dumm);


            float value = 2.7f;
            var intvalue = (int)value;

            var eee = DateTime.Now.ToString(DateTime.Now.ToString("ddMMyyyhhmmss"));
            var wwee = (DateTime.Now.ToString("ddMMyyyhhmmss"));


            Console.WriteLine(eee);
            Console.WriteLine(wwee);

            decimal xxx =(decimal) 1 / 10;
            Console.WriteLine(xxx);

            string ddd = "0020-08-17T16:35:47+05:53:28";
            string dd1 = "2020-09-15T12:58:56.06674+05:30";
            DateTime dateTime = Convert.ToDateTime(ddd);

            Console.WriteLine(dateTime);


            //Console.WriteLine(System.Data.SqlTypes.SqlDateTime.MaxValue.Value.ToString());
            //Console.WriteLine(System.Data.SqlTypes.SqlDateTime.MinValue.Value.ToString());
            //Console.WriteLine(DateTime.Now.ToShortDateString());
            //Console.WriteLine(DateTime.MaxValue.ToShortDateString());
            //Console.WriteLine(DateTime.MinValue.ToShortDateString());
            ////PayPalPayment payPalPayment = new PayPalPayment();

            //string msg = string.Empty;
            //string payal = "SUCCESS mc_gross=51.00 invoice=11f08934-190b-4552-843e-402d34d182ac protection_eligibility=Eligible address_status=confirmed item_number1= payer_id=9EJJCYDRJMGUE tax=0.00 address_street=123+Thomson+Rd. payment_date=22%3A51%3A27+Jan+30%2C+2019+PST payment_status=Completed charset=gb2312 address_zip=308123 mc_shipping=0.00 mc_handling=0.00 first_name=Nagaraju mc_fee=2.23 address_country_code=SG address_name=R+Nagaraju custom=https%3A//nagesh.brightskool.com payer_status=verified business=ej-seller%40bst.com address_country=Singapore num_cart_items=1 mc_handling1=0.00 address_city=Singapore payer_email=ej-buyer%40bst.com mc_shipping1=0.00 tax1=0.00 txn_id=7G1866612H942434S payment_type=instant last_name=R address_state= item_name1=Ultimate receiver_email=ej-seller%40bst.com payment_fee= shipping_discount=0.00 quantity1=1 insurance_amount=0.00 receiver_id=HG7QZYTPCG8E4 txn_type=cart discount=0.00 mc_gross_1=51.00 mc_currency=SGD residence_country=SG shipping_method=Default transaction_subject= payment_gross=";
            //msg += payal;
            //Class2 cl = new Class2();
            //payPalPayment = cl.Parse(payal, false);

            //string serialized = JsonConvert.SerializeObject(payPalPayment);

            //string data = "there is a cat";
            //// Split string on spaces (this will separate all the words).
            //char sp = ' ';
            //char curr = sp;
            //string[] words = data.Split(curr);
            //foreach (string word in words)
            //{
            //    Console.WriteLine("WORD: " + word);
            //}

            //List<string> permissions = new List<string> { "Dashboard", "Dashboard", "Dashboard", "SchoolProfile", "SchoolProfile", "Settings", "Customforms", "Enquiry" };

            //List<string> Removedpermissions = new List<string> { "Dashboard", "SchoolProfile", "Enquiry" };

            //List<string> Addedpermissions = new List<string> { "Student", "Course" };


            //List<user> users1 = new List<user>();
            //users1.AddRange(users);
            //users1.AddRange(users);

            //var u = users.FirstOrDefault(_ => _.name == "sdfdsfkj");

            //Removedpermissions.ForEach(_ => permissions.Remove(_));
            //permissions.AddRange(Addedpermissions);

            //foreach(string per in permissions)
            //{
            //    Console.WriteLine(per);

            //}

            //permissions.Add("Dashboard");

            //string dt = "01-Jan-2019";
            //DateTime dateTime = DateTime.Parse(dt);
            //DateTime date = DateTime.Now.AddMonths(1);

            Console.ReadLine();
        }
    }
}


