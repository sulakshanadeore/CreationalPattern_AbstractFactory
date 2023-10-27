using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern_AbstractFactory
{
    //abstract class -- use a combination of interfaces, abstract class combiantion can also be used.
	public abstract class AbstractProductCategoryBeverages
	{
	public abstract	void ShowProducts();
	}
       public class Product_Tea : AbstractProductCategoryBeverages
    {
        public override void ShowProducts()
        {
            throw new NotImplementedException();
        }
    }
    public class Product_Coffee : AbstractProductCategoryBeverages
    {
        public override void ShowProducts()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class AbstractProductCategorySnacks
    { 
    
    }
    public class Product_Maggi : AbstractProductCategorySnacks { }
    public class Product_Pasta : AbstractProductCategorySnacks { }


    public abstract class AbstractFactory
    { 
    public abstract AbstractProductCategoryBeverages CreateProductA1();
        public abstract AbstractProductCategorySnacks CreateProductB1();

    }

    public class Client
    {
        private  AbstractProductCategoryBeverages _product1_Tea;
        private AbstractProductCategoryBeverages _product1_Coffee;

        private AbstractProductCategorySnacks _product2_Maggi;
        private AbstractProductCategorySnacks _product2_Pasta;

        public Client(AbstractFactory factory)
        {
            _product1_Tea=factory.CreateProductA1();
            _product1_Coffee = factory.CreateProductA1();
            _product2_Maggi = factory.CreateProductB1();
            _product2_Pasta = factory.CreateProductB1();

        }
    }

    public class ConcreateFactoryA1 : AbstractFactory
    {
        public override AbstractProductCategoryBeverages CreateProductA1()
        {
            throw new NotImplementedException();
        }

        public override AbstractProductCategorySnacks CreateProductB1()
        {
            throw new NotImplementedException();
        }
    }
    public class ConcreateFactoryB1 : AbstractFactory
    {
        public override AbstractProductCategoryBeverages CreateProductA1()
        {
            throw new NotImplementedException();
        }

        public override AbstractProductCategorySnacks CreateProductB1()
        {
            throw new NotImplementedException();
        }
    }



}
