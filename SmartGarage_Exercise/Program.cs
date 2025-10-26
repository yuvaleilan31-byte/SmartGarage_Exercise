namespace SmartGarage_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("--- Welcome to Smart Garage (v1.0 - Messy) ---");

			// --- יצירת האובייקטים הנפרדים ---
			Car car1 = new Car("Subaru Impreza", 20);
			Motorcycle bike1 = new Motorcycle("Kawasaki Ninja", 40);
			CleaningRobot robot1 = new CleaningRobot("S-500", 15);

			// --- הדרך הישנה והמסורבלת ---
			// אנו נאלצים להחזיק 3 מערכים נפרדים!
			Car[] carFleet = { car1 };
			Motorcycle[] bikeFleet = { bike1 };
			CleaningRobot[] robotFleet = { robot1 };

			// הפעלת הפונקציות הישנות
			SmartGarageTester.RefuelAllCars(carFleet);
			SmartGarageTester.ChargeAllRobots(robotFleet);
			SmartGarageTester.MoveAllRight(carFleet, bikeFleet, robotFleet);

			// הפעלת הפעולות הייחודיות - אין ברירה אלא לעשות זאת ידנית
			car1.Drive();
			bike1.Drive();
			robot1.StartCleaning();


			// -----------------------------------------------------------------
			// --- המטרה הסופית (הקוד הזה נמצא בהערה כי הוא לא יתקמפל) ---
			// --- התלמידים צריכים לגרום לקוד הבא לעבוד ---
			// -----------------------------------------------------------------

			/*
            Console.WriteLine("\n\n--- Welcome to Smart Garage (v2.0 - Refactored!) ---");

            // שלב 1: הוספת הלקוח החדש (משימה 3)
            Drone drone1 = new Drone("DJI-Mavic", 30);

            // שלב 2: יצירת מערכים פולימורפיים חכמים
            
            // מערך אחד לכל מה שהוא "כלי רכב" (ירושה)
            Vehicle[] allVehicles = { car1, bike1 };

            // מערך אחד לכל מה שהוא "יכול לזוז" (ממשק IMovable)
            // שימו לב שהוא מכיל סוגי אובייקטים שונים לחלוטין!
            IMovable[] allMovables = { car1, bike1, robot1, drone1 };

            // שלב 3: הפעלת הפונקציות החדשות והיעילות
            
            // 3א: בדיקת מערך כלי הרכב
            SmartGarageTester.TestAllVehicles(allVehicles);
            
            // 3ב: בדיקת מערך הזזים (כולל בדיקת טעינה פנימית)
            SmartGarageTester.TestMovablesAndChargeables(allMovables);

            // עדיין ניתן להפעיל פעולות ייחודיות בנפרד
            robot1.StartCleaning();
            drone1.Fly();
            */
		}
	}

}
    

