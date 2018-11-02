/*============ short and big caracter problem (1) cS code ========================*/
 bool valid = false;
             string input ;
            char output = (char) 0;
             while(!valid)
             {
                 Console.WriteLine("enter a later btwen \"a\"and \"z\" ");
                input = Console.ReadLine();
                if (char.TryParse(input, out output))
                {
                    if (output < ((char)97) || output > ((char)122))
                    {
                        Console.WriteLine("pleaz enter a corect carecter");
                        valid = false;
                    }
                    else
                        valid = true;
                }
                else
                    valid = false;


             }
                 if(valid)
             {
                
                output -= (char) 32;
                 Console.WriteLine("you enter " + output + " as big");
             }
/*============ 3 point in one line problem (2) cS code ========================*/
Console.WriteLine("\t\t\t\t*=*=*=*= ARE THEY IN THE SAME LINE =*=*=*=*");
            double[] x = new double[3];
            double[] y = new double[3];


            for (int i = 0; i < 3; i++)
            {
                string input;
                bool validx = false;
                bool validy = false;
                while (!validx)
                {
                    Console.WriteLine("enter x" + (i + 1) + " cordinat");
                    input = Console.ReadLine();
                    if (double.TryParse(input, out x[i]))
                    {
                        validx = true;
                    }
                    else
                    {
                        validx = false;
                    }
                }
                while (!validy)
                {
                    Console.WriteLine("enter y" + (i + 1) + " cordinat");
                    input = Console.ReadLine();
                    if (double.TryParse(input, out y[i]))
                    {
                        validy = true;
                    }
                    else
                    {
                        validy = false;
                    }
                }


            }
            //line equation is y=ax+b
            double[] a = new double[3];
            double bast = 0;
            /*-------------------------*/
            bast = (x[1] - x[0]);
            if (bast == 0)
                Console.WriteLine("you are not alowed");
            else
                a[0] = (y[1] - y[0]) / bast;
            /*-------------------------*/
            bast = (x[2] - x[1]);
            if (bast == 0)
                Console.WriteLine("you are not alowed");
            else
                a[1] = (y[2] - y[1]) / bast;
            /*-------------------------*/
            bast = (x[2] - x[0]);
            if (bast == 0)
                Console.WriteLine("you are not alowed");
            else
                a[2] = (y[2] - y[0]) / bast;
            if (a[0] == a[1] && a[1] == a[2])
            {
                Console.WriteLine("they are in the same line");
                Console.WriteLine("THE hypotenuse =" + a[0]);
            }
            else 
            {
                Console.WriteLine("they are NOT in the same line");
                foreach (double hyp in a)
                    Console.WriteLine("hypotenuse=" + hyp);
            }

/*============ in on out the circule problem (3) cS code ========================*/
 static void Main(string[] args)
        {
            double radius = 0;
            double x = 0, y = 0, s = 0, xc = 0, yc=0 ;
            radius=scanf("radise");
            xc = scanf("x cordinat of the  center");
            yc = scanf("y cordinat of the  center");
            x =scanf( "x");
            y=scanf( "y");

            s = Math.Pow((x-xc), 2) + Math.Pow((y-yc), 2);


            if (s > Math.Pow(radius, 2))
                Console.WriteLine("the point is OUT the circule");
           else if (s < Math.Pow(radius, 2))
                Console.WriteLine("the point is IN the circule");
            else
                Console.WriteLine("the point is ON the circule");
        }
       static double scanf ( string message )
        {
            bool valid = false;
            double data = 0;
            while (!valid)
            {
                Console.WriteLine("Enter the "+message);
                string input = Console.ReadLine();
                
                if (double.TryParse(input, out data))
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                    Console.WriteLine("please enter a valid number ");
                }

            }
            return data;
        }
 /*============ problem (4) cS code ========================*/