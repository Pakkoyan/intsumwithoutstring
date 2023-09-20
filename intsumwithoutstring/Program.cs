
int num = Int32.Parse(Console.ReadLine());
int sum = 0;

if (num / 10 != 0)
{
    sum += num % 10;
    num /= 10;
}
if (num / 10 != 0)
{
    sum += num % 10;
    num /= 10;
}
if (num / 10 != 0)
{
    sum += num % 10;
    num /= 10;
}
if (num / 10 != 0)
{
    sum += num % 10;
    num /= 10;
}
if (num / 10 != 0)
{
    sum += num % 10;
    num /= 10;
}
if (num / 10 != 0)
{
    sum += num % 10;
    num /= 10;
}
if (num / 10 != 0)
{
    sum += num % 10;
    num /= 10;
}
if (num / 10 != 0)
{
    sum += num % 10;
    num /= 10;
}
if (num / 10 != 0)
{
    sum += num % 10;
    num /= 10;
}

Console.WriteLine(sum + num);

