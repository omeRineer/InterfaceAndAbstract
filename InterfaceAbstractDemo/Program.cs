using Business.Abstract;
using Business.Adapters;
using Business.Concrete;
using Entities.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerService = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerService.Add(new Customer {FirstName="Ömer Faruk",LastName="Sandıkçı",NationalityId="11720526442",DateOfBirth=new DateTime(2001,10,04) });
        }
    }
}
