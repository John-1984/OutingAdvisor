using ApplicationObjects.BO;
using ApplicationObjects.Shared;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Implementation
{
    public class LocationDL:ILocation
    {
        public LocationBO GetLocationDetails(Search searchDetails)
        {
            //Call the SP
            return new LocationBO()
            {
                Name = "Yercaud, TamilNadu",
                FullDescription = "Yercaud Gaut Road" + System.Environment.NewLine + "The scenic route leading to Yercaud." + System.Environment.NewLine +
                "It is 358 km from Chennai (via. Tindivanam) 222 km from Bangalore (via. Hosur - Krishnagiri - Dharmapuri - Salem - Yercaud) . It will take approx 5hrs to drive. One day trip is sufficient from Bangalore. Start early morning reach yercaud around 9 am , spend the whole day and start from yercuad around 4pm. It is enough. Only thing is you will not be able to see the falls as it will take time trek." + System.Environment.NewLine +
                "190 km from Coimbatore (via. Avinashi) 163 km from Trichy (via. Namakkal) 271 km from Madurai (via. Karur) 80 km from Mettur (via. Toppur)" + System.Environment.NewLine +
                "By Taxi[edit]" + System.Environment.NewLine +
                "taxiGUIDE.in (Car Rental to Yercaud), ☎ +91 888 023 4455 (support@taxiguide.in), [1]. Inquiry: 7am to 11pm. Car Rental services to Yercaud on taxiGUIDE.in - a Chauffeur Driven Car Rental service in 75 Cities in India. Car Rental to Yercaud from Bangalore and Chennai.  edit",
                ShortDescription = "Yercaud is a hill station in Salem District, in Tamil Nadu, India." + System.Environment.NewLine +
                "It located in the Shevaroys range of hills in the Eastern Ghats; the Yercaud hill area is called the Shevaroy Hills. " + System.Environment.NewLine +
                "It is situated at an altitude of 1515 metres (4970 ft) above sea level. " + System.Environment.NewLine +
                "Coffee and citrus fruits, most notably oranges, are grown in abundance apart from bananas, pears and jackfruit." + System.Environment.NewLine +
                "Scenically, Yercaud is as enchanting and picturesque as the hill stations on the Western ghats and trekking here can be one of the most pleasurable ways to pass time.",
                TravelTips = new List<string>() { "Better to take extra tyre just in case.", "Carry a first aid kit with you.", "Travel by Bike is very Enjoyable." },
                HotelTips = new List<string>() { "Hotels are costly.", "Cheap Paying Guest Facilities are available." }
            };
        }
    }
}
