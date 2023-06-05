using Lab4Library;

Console.WriteLine("Choise on of tasks\n1 - Adapter\n2 - Decorator\n3 - Facade\n4 - Bridge");
int n = Int32.Parse(Console.ReadLine());
switch (n)
{
    case 1:
        var fileWriter = new FileWriter();
        var fileLogger = new FileWriterAdapter(fileWriter);

        fileLogger.Log("Message 1\n");
        fileLogger.Error("Message 2");
        fileLogger.Warn("Message 3\n");

        var logger = new Logger();
        logger.Log("Message 4");
        logger.Error("Message 5");
        logger.Warn("Message 6");
        break;
    case 2:
        Hero warrior = new Warrior();
        Hero mage = new Mage();
        Hero paladin = new Paladin();

   
        warrior = new WeaponInventoryDecorator(new ClothingInventoryDecorator(warrior));
        mage = new ArtifactInventoryDecorator(new WeaponInventoryDecorator(mage));
        paladin = new ClothingInventoryDecorator(new ArtifactInventoryDecorator(paladin));

        warrior.ShowInventory();
        mage.ShowInventory();
        paladin.ShowInventory();
        break;
    case 3:
        BigMacMenu bigMacMenu = new BigMacMenu(new BigMac(), new Fries(),new Beverage(),new Wrapper(),new Napkin(), new Bag(),new Price(150,"UAH"), new Sauce());
        bigMacMenu.PrepareMenu();
        break;
    case 4:
        IRenderer vectorRenderer = new VectorRenderer();
        IRenderer rasterRenderer = new RasterRenderer();

        Shape circle = new Circle(vectorRenderer);
        Shape square = new Square(rasterRenderer);
        Shape triangle = new Triangle(vectorRenderer);

        circle.Draw();
        square.Draw();
        triangle.Draw();
        break;
    default: break;
}