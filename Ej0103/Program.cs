using Ej0103;

IShape c = new Circle(5);
IShape r = new Rectangle(4, 6);

PrintShapeInfo(c);
PrintShapeInfo(r);
void PrintShapeInfo(IShape shape)
{
    Console.WriteLine($"Shape: {shape.GetName()}, Area: {shape.GetArea()}");
}