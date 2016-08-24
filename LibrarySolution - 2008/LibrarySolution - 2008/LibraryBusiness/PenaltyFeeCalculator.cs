using System;
using System.Collections.Generic;
using System.Text;
using LibraryConfigUtilities;

namespace LibraryBusiness
{
    /* Description,
     * settingList member holds configuration parameters stored in the App.config file, 
     * please explore the properties and methods in the Country class to get a better understanding.
     * 
     * Please implement this class accordingly to accomplish requirements.
     * Feel free to add any parameters, methods, class members, etc. if necessary
     */
    public class PenaltyFeeCalculator{
        
        private List<Country> settingList = new LibrarySetting().LibrarySettingList;
        
        public PenaltyFeeCalculator() {
            
        }

        public String Calculate(){
            {
                DateTime startDate = new DateTime();
                DateTime endDate = new DateTime();
                int countyrCode =new int();
                double totalfee=new double();
                

                Console.WriteLine("Please, Enter the start Date (dd.mm.yyyy)): ");
                startDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Please, Enter the End Date : (dd.mm.yyyy) ");
                endDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Please, Enter the Country  Code : \n Tr - 1 \n Ae - 2 ");
                countyrCode = Convert.ToInt32(Console.ReadLine());
                
                var feeday = (endDate.Day - startDate.Day);
                

                feeday = feeday - 3; //Cezasý olmayan 3 günü düþürdüm ilerde kontrol yapacaðým.
                DateTime dateX=new DateTime();

                Console.WriteLine(feeday);
                Console.ReadLine();
                dateX = startDate;
                while (endDate != dateX)
                {
                    if ((dateX.DayOfWeek == DayOfWeek.Saturday) || (dateX.DayOfWeek == DayOfWeek.Sunday))
                    {
                        feeday = feeday - 1; //Haftasonlarýný Çýkarttým
                        dateX = dateX.AddDays(1);
                    }

                }


                if (feeday > 0)
                {
                    return "0";
                }
                else
                {
                    switch (countyrCode)
                    {
                        case 1:
                            totalfee = feeday * 5.25;

                            break;
                        case 2:

                            totalfee = feeday * 8;
                            break;
                        default:
                            Console.WriteLine("Error Country Code.!!!");
                            break;
                    }
                }

              
                return totalfee.ToString();

            }
        }
    }
}
