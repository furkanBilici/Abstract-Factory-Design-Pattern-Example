using AbstractFactory.Abstract;
using AbstractFactory.Class;
using AbstractFactory.Class.Business;
using AbstractFactory.Class.Cache;

ProductManager productManager = new ProductManager(new Factory1());
productManager.GetAll();