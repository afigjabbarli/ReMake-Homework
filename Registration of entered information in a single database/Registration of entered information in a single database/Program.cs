using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Registration_of_entered_information_in_a_single_database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int[] total = { 0 };
            string[] text = new string[6];
            decimal[] digits = new decimal[2];
            string[] positions = new string[] { "Human Resources","Audit", "Engineer" };
            Console.WriteLine("Entering Information About the Company's Employees into a Single Database");
            Console.WriteLine();
            Console.WriteLine("Click the button that you want to enter the parameter");
            Console.WriteLine();
            Console.WriteLine("[*]-//Enter the name of the employee of the company//");
            Console.WriteLine("[*]-//Enter the lastname of the employee of the company//"); 
            Console.WriteLine("[*]-//Enter the name of the company employee's father//"); 
            Console.WriteLine("[*]-//Enter the age of the employee of the company//"); 
            Console.WriteLine("[*]-//Enter the the personal identification number of the identity card of the employee of the company//");
            Console.WriteLine("[*]-//Enter the phone number of the employee of the company//");
            Console.WriteLine("[*]-//Enter the position of the employee of the company//");
            Console.WriteLine("[*]-//Enter the monthly income of the employee of the company//");
            Console.WriteLine();
            while (true)
            {
            Console.WriteLine(" ");
            Console.Write("Enter the parameter type:");Console.Write(" ");string parameter = Console.ReadLine();
            Console.WriteLine();
            if(parameter == "//Enter the name of the employee of the company//")
            {
                while (true)
                {
                  Console.Write("Company employee's name:");Console.Write(" ");string name = Console.ReadLine();
                        text[1] = name;
                  bool isCheck14 = CheckingName(name);
                    if (isCheck14)
                    {
                        total[0] += 1;
                    }
                    else
                    {
                        Console.WriteLine("The minimum length of the name characters you enter should be 2 and the maximum length should be 20");
                    }
                    bool isCheck15 = CheckingName1(name, uppercaseLetters);
                    if (isCheck15)
                    {
                        total[0] += 1;
                    }
                    else
                    {
                        Console.WriteLine("The first character of the name you enter must begin with an uppercase letter");
                    }
                    bool isCheck16 = CheckingName2(name, lowerLetters);
                    if(isCheck16)
                    {
                        total[0] += 1;
                    }
                    else
                    {
                        Console.WriteLine("Except for the first character of the name you entered, the following characters must be capitalized");
                    }
                    if(isCheck14 == true && isCheck15 == true && isCheck16 == true)
                    {
                        Console.WriteLine("Correct");
                        
                        break;
                    }
                }
            }
            if(parameter == "//Enter the lastname of the employee of the company//")
            {
                while (true)
                {
                 Console.Write("Lastname of the employee of the company:");Console.Write(" ");string lastName = Console.ReadLine();
                        text[0] = lastName;
                    bool isCheck11 = CheckingLastName(lastName);
                    if (isCheck11)
                    {
                        total[0] += 1;
                    }
                    else
                    {
                        Console.WriteLine("The minimum number of characters you enter should be 2, and the maximum number should be 35");
                    }
                    bool isCheck12 = CheckingLastName1(lastName, uppercaseLetters);
                    if (isCheck12)
                    {
                        total[0] += 1;
                    }
                    else
                    {
                        Console.WriteLine("The first character of the name you enter must be capitalized");
                    }
                    bool isCheck13 = CheckingLastName2(lastName, lowerLetters);
                    if (isCheck13)
                    {
                        total[0] += 1;
                    }
                    else
                    {
                        Console.WriteLine("Except for the first character of the name you entered, the following characters must be capitalized");
                    }
                    if(isCheck11 == true && isCheck12 == true && isCheck13 == true)
                    {
                        Console.WriteLine("Correct");
                        break;
                    }
                }

            }
            if (parameter == "//Enter the name of the company employee's father//")
            {
                while (true)
                {
                 Console.Write("Name of the company employee's father:");Console.Write(" "); string fatherName = Console.ReadLine();
                 text[2] = fatherName;
                 bool isCheck8 = CheckingFatherName(fatherName);
                 if (isCheck8)
                 {
                        total[0] += 1;
                 }
                 else
                 {
                  Console.WriteLine("The minimum length of the name characters you enter should be 2 and the maximum length should be 20");
                 }
                 bool isCheck9 = CheckingFatherName1(fatherName, uppercaseLetters);
                    if (isCheck9)
                    {
                        total[0] += 1;
                    }
                    else
                    {
                        Console.WriteLine("The first character of the name you enter must be capitalized");
                    }
                    bool isCheck10 = CheckingFatherName2(fatherName, lowerLetters);
                    if (isCheck10)
                    {
                        total[0] += 1;
                    }
                    else
                    {
                        Console.WriteLine("Except for the first character of the name you entered, the following characters must be capitalized");
                    }
                    if (isCheck8 == true && isCheck9 == true && isCheck10 == true)
                    {
                        Console.WriteLine("Correct");
                        break;
                    }
                }
                    
            }
            if (parameter == "//Enter the age of the employee of the company//")
            {
                while (true)
                {
                 Console.Write("The person's age:");Console.Write(" "); int age = int.Parse(Console.ReadLine());
                        digits[0] = age;
                    bool isCheck7 = CheckingAge(age);
                    if (isCheck7)
                    {
                        Console.WriteLine("Correct");
                        total[0] += 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The age range you enter must be minimum 18 and maximum 65...");
                    }
                }
            }
            if (parameter == "//Enter the the personal identification number of the identity card of the employee of the company//")
            {
                while (true)
                {
                 Console.Write("Personal identification number:");Console.Write(" "); string pinNumber = Console.ReadLine();
                        text[3] = pinNumber;
                    bool isCheck4 = CheckingPinNumber(pinNumber);
                    if (isCheck4)
                    {
                       total[0] += 1;
                    }
                    else
                    {
                        Console.WriteLine("The length of the personal identification code you enter must be 7");
                    }
                    bool isCheck5 = CheckingPinNumber1(pinNumber, numbers);
                    if(isCheck5)
                    {
                        total[0] += 1;
                    }
                    else
                    {
                        Console.WriteLine("The digits in the personal identification code you enter must be used");
                    }
                    bool isCheck6 = CheckingPinNumber2(pinNumber, lowerLetters);
                    if (isCheck6)
                    {
                        total[0] += 1;
                    }
                    else
                    {
                        Console.WriteLine("The personal identification code you enter must be in capital letters");
                    }
                    bool isCheckk = CheckingPinNumber3(pinNumber, uppercaseLetters);
                    if (isCheckk)
                    {
                        total[0] += 1;
                    }
                    else { Console.WriteLine("Only capital letters can be used in the entered personal identification code"); }
                    if (isCheck4 == true && isCheck5 == true && isCheck6 == true && isCheckk == true)
                    {
                        Console.WriteLine("Correct");
                        break;
                    }
                }   
            }
            if (parameter == "//Enter the phone number of the employee of the company//")
            {
                while (true)
                {
                    Console.Write("Phone number:");Console.Write(" "); string phoNumber = Console.ReadLine();
                        text[4] = phoNumber;
                    bool isCheck2 = CheckingPhoneNumber(phoNumber);
                    if (isCheck2)
                    {
                        total[0] += 1;
                        
                    }
                    else
                    {
                     Console.WriteLine("The length of the phone number you entered must be 13");
                    }
                    bool isCheck3 = CheckingPhoneNumber1(phoNumber);
                    if (isCheck3)
                    {
                        total[0] += 1;
                        
                    }
                    else { Console.WriteLine("The phone number you enter must start with the code +994"); }
                    if(isCheck2 == true && isCheck3 == true)
                    {
                        Console.WriteLine("Correct");
                        break;
                    }
                }
            }
            if (parameter == "//Enter the position of the employee of the company//")
            {
                while (true)
                {
                 Console.Write("Position:"); Console.Write(" "); string position = Console.ReadLine();
                        text[5] = position;
                    bool isCheck1 = CheckingPosition(position, positions);
                    if (isCheck1)
                    {
                        total[0] += 1;
                        Console.WriteLine("Correct");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("There is no such position in the company");
                    }
                }
            }
            if(parameter == "//Enter the monthly income of the employee of the company//")
            {
                while(true)
                {
                 Console.Write("Monthly income:"); Console.Write(" "); decimal monthlyIncome = int.Parse(Console.ReadLine());
                        digits[1] = monthlyIncome;
                    bool isCheck = CheckingMonthlyIncome(monthlyIncome);
                    if(isCheck)
                    {
                        total[0] += 1;
                            
                        Console.WriteLine("Correct");
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The interval you entered is incorrect");
                    }
                    
                }
            }
            if (total[0] == 18)
            {
             Console.WriteLine();
             Console.WriteLine("CORRECT");
             Console.WriteLine();
             Console.WriteLine("Information about the person:");
             Console.WriteLine(text[0] + " " + text[1] + " " + text[2]);
             Console.WriteLine("Age of person:" + " " + digits[0]);
             Console.WriteLine("Personal identification number:" + " " + text[3]);
             Console.WriteLine("Phone Number:" + " " + text[4]);
             Console.WriteLine("Position:" + " " + text[5]);
             Console.WriteLine("Monthly Income:" + " " + digits[1]);
             Console.WriteLine();
             Console.WriteLine("The information was successfully entered into the unified information base of the company.");
             Console.WriteLine("THANKS FOR USING.BYE BYE...");
             break;
             
            
            }





            if (parameter != "//Enter the name of the employee of the company//" && parameter != "//Enter the lastname of the employee of the company//" && parameter != "//Enter the name of the company employee's father//" && parameter != "//Enter the age of the employee of the company//" && parameter != "//Enter the the personal identification number of the identity card of the employee of the company//" && parameter != "//Enter the phone number of the employee of the company//" && parameter != "//Enter the position of the employee of the company//" && parameter != "//Enter the monthly income of the employee of the company//")
            {
            
             Console.WriteLine(" ");
             Console.WriteLine("This option is not available in the menu.Please re-enter...");
               
            }
            }
        }
        public static bool CheckingName(string name)
        {
            if(name.Length > 2 && name.Length < 20)
            {
                return true;
            }
            return false;
        }
        public static bool CheckingName1(string name, char[] uppercaseLetters)
        {
            char letter = name[0];
            for (int idx6 = 0; idx6 < uppercaseLetters.Length ; idx6++)
            {
                if (uppercaseLetters[idx6] == letter)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckingName2(string name, char[] lowerLetters)
        {
            for (int idx7 = 1; idx7 < name.Length; idx7++)
            {
                char letter = name[idx7];
                for (int idx8 = 0; idx8 < lowerLetters.Length; idx8++)
                {
                    if (letter == lowerLetters[idx8])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool CheckingLastName2(string lastName, char[] lowerLetters)
        {
            for (int idx1 = 1; idx1 < lastName.Length; idx1++)
            {
                for (int idx2 = 0; idx2 < lowerLetters.Length; idx2++)
                {
                    if (lastName[idx1] == lowerLetters[idx2])
                    {
                        return true;
                    }
            
                }
            }
            return false;


        }
        public static bool CheckingLastName1(string lastName, char[] uppercaseLetters)
        {
            for (int idx = 0; idx < uppercaseLetters.Length; idx++)
            {
             char letter = lastName[0];
             if(letter == uppercaseLetters[idx])
                {
                    return true;
                }
            
            }
            return false;
        }
        public static bool CheckingLastName(string lastName)
        {
        if(lastName.Length > 2 && lastName.Length < 35)
            {
                return true;
            }
        return false;
        }
        public static bool CheckingFatherName2(string fatherName, char[] lowerLetters)
        {
            for (int ffindex = 1; ffindex < fatherName.Length; ffindex++)
            {
                for (int fffindex = 0; fffindex < lowerLetters.Length; fffindex++)
                {
                    if (fatherName[ffindex] == lowerLetters[fffindex])
                    {
                        return true;
                    } 
                        
                }
            }
            return false;
        }
        public static bool CheckingFatherName1(string fatherName, char[] uppercaseLetters)
        {
            for (int findex = 0; findex < uppercaseLetters.Length; findex++)
            {
                char letter = fatherName[0];
                
                if(letter == uppercaseLetters[findex])
                {
                
                    return true;
                }
            }
                return false;


        }
        public static bool CheckingFatherName(string fatherName)
        {
         if(fatherName.Length > 2 && fatherName.Length < 20)
            {
             return true;
            }
            return false;
        }
        public static bool CheckingAge(int  age)
        {
         if(age > 18 && age < 65)
            {
                return true;
            }

            return false;  
                
        }
        public static bool CheckingPinNumber3(string pinNumber, char[] uppercaseLetters)
        {
            for (int idx4 = 0; idx4 < pinNumber.Length; idx4++)
            {
             char letter = pinNumber[idx4];
                for (int idx5 = 0; idx5 < uppercaseLetters.Length; idx5++)
                {
                    if (letter == uppercaseLetters[idx5])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool CheckingPinNumber2(string pinNumber, char[] lowerLetters)
        {
            for (int i = 0; i < pinNumber.Length; i++)
            {
             char letter = pinNumber[i];
                for (int x = 0; x < lowerLetters.Length; x++)
                {
                 if(letter != lowerLetters[x])
                    {
                        
                        
                     return true;
                        
                    }
            
                }
            
            }
            return false;
            
        }
        
        public static bool CheckingPinNumber1(string pinNumber, char[] numbers)
        {
            for (int index = 0; index < pinNumber.Length; index++)
            {
                char letter = pinNumber[index];
                for (int index1 = 0; index1 < numbers.Length; index1++)
                {
                 if (numbers[index1] == letter)
                    {
                        return true; 
                    }

                }
            }
                return false;

        }
        
        public static bool CheckingPinNumber(string pinNumber)
        {
         if (pinNumber.Length == 7)
            {
             return true;
            }
         return false;

        }
          
        public static bool CheckingPhoneNumber1(string phoNumber)
        {
         if (phoNumber[0] == '+'&&
             phoNumber[1] == '9'&&
             phoNumber[2] == '9'&&
             phoNumber[3] == '4')
            {
                return true;
            }
          return false;
        
        
        }

        public static bool CheckingPhoneNumber(string phoNumber)
        {
            if (phoNumber.Length == 13)
            {
                return true;
            }
            return false;


        }

        public static bool CheckingPosition(string position, string[] positions)
        {
            for (int idx = 0; idx < positions.Length; idx++)
            {
             if (position == positions[idx])
                {
                    return true;
                }
            }
            return false;
        }                

        public static bool CheckingMonthlyIncome(decimal monthlyIncome)
        {
            if (monthlyIncome > 1500 && monthlyIncome < 5000)
            {
                return true;
            }
            return false;
        }


        


                  
                    
                
                        
                            
                            







                    







        
        
        
        
        

            
        


        



















































































    }
}