Type fileStreamTypeInfo = typeof(FileStream);

Type[] implementedInterfaces = fileStreamTypeInfo.GetInterfaces();

foreach (var iface in implementedInterfaces)
{
  Console.WriteLine(iface.Name);
}