using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_C2
{
    //commit lan3
    enum ShippingMethod
    {
        Standard_224,
        Express_224,
        Overnight_224
    }
    class ShippingService
    {
        public static double GetShippingCost(ShippingMethod method_224, double? custom_224 = null)
        {
            double DefaultCost_224;
            switch (method_224)
            {
                case ShippingMethod.Standard_224:
                    DefaultCost_224 = 5;
                    break;
                case ShippingMethod.Express_224:
                    DefaultCost_224 = 10;
                    break;
                case ShippingMethod.Overnight_224:
                    DefaultCost_224 = 15;
                    break;
                default:
                    throw new ArgumentException("Invalid shipping method");
            }
            return custom_224 ?? DefaultCost_224;
        }

        public static int GetDeliveryDays(ShippingMethod method)
        {
            switch (method)
            {
                case ShippingMethod.Standard_224:
                    return   5;
                case ShippingMethod.Express_224:
                    return   2;
                case ShippingMethod.Overnight_224:
                    return   1;
                default:
                    throw new ArgumentException("Invalid shipping method");
            }
        }
    }
    class Program
    {
     
        static void Main(string[] args)
        {
            ShippingMethod method_224;
            method_224 = ShippingMethod.Express_224;

            
            Console.WriteLine($"Shipping method: {method_224}");
            Console.WriteLine($"Shipping cost: {ShippingService.GetShippingCost(method_224)}");
            Console.WriteLine($"Shipping cost: {ShippingService.GetDeliveryDays(method_224)}");

            //Optional Prameter
            Console.WriteLine($"Shipping cost: {ShippingService.GetShippingCost(method_224, 3)}");
            Console.ReadKey();
        }
    }
}
