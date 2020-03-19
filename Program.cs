using System;

namespace Assignment6
{
    class Program
    {

        //main method to call various other methods
        static void Main(string[] args)
        {

            Console.WriteLine("Parking permit System");
            Read();
            Create();
            Update();
            Read();
            Delete();
            Read();

        }

        //Read - to print all records in the Database
        static void Read()
        {
            using (var db = new Assignment6Context())
            {

                Console.WriteLine("All permits in database");
                foreach (var v in db.Vehicle)
                {
                    Console.WriteLine("StudentID " + v.StudentId.ToString() + " Model: " + v.VehicleModel + " Reg " + v.Registration +
                        " Owner Name " + v.Owner + " Apartment # " + v.Apartment.ToString());

                }
            }
        }

        //Insert - insert a new record in the database
        static void Create()
        {
            using (var db = new Assignment6Context())
            {
                db.Vehicle.Add(new Vehicle
                {
                    StudentId = 00000004,
                    VehicleModel = "Hyundai",
                    Registration = "151G5640",
                    Owner = "Ger Lyons",
                    Apartment = 7
                });
                db.SaveChanges();
                Console.WriteLine("Record saved to database");
                Console.WriteLine();
            }
        }



        //update - a record
        static void Update()
        {
            using (var db = new Assignment6Context())
            {
                Console.WriteLine("update");
                Vehicle vehicle = db.Vehicle.Find(1);
                vehicle.Owner = "Mary Bonk";
                db.SaveChanges();

            }
        }

        //delete - a record
        static void Delete()
        {
            {
                using (var db = new Assignment6Context())
                {

                    Vehicle vehicle = db.Vehicle.Find(2);
                    db.Vehicle.Remove(vehicle);
                    db.SaveChanges();


                }


            }

        }
    }

}