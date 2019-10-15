using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prog2
{
   static class GlobalClass
   {
      private static string Quantityglbl = "";
      public static string GlobalQuan
      {
         get { return Quantityglbl; }
         set { Quantityglbl = value; }
      }

      private static string IDglbl = "";
      public static string GlobalID
      {
         get { return IDglbl; }
         set { IDglbl = value; }
      }
      private static string Priceglbl = "";
      public static string GlobalPrice
      {
         get { return Priceglbl; }
         set { Priceglbl = value; }
      }
      private static string Subglbl = "";
      public static string GlobalSub
      {
         get { return Subglbl; }
         set { Subglbl = value; }
      }
      private static string Taxglbl = "";
      public static string GlobalTax
      {
         get { return Taxglbl; }
         set { Taxglbl = value; }
      }
      private static string Totalglbl = "";
      public static string GlobalTotal
      {
         get { return Totalglbl; }
         set { Totalglbl = value; }
      }
   }
}