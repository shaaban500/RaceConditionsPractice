int count = 0;
object pblock = new object();
void doWork()
{
    for (int i = 0; i < 1000000; i++)
    {
        lock (pblock)
        {
            count++;
        }
    }
}



Thread t1 = new Thread(doWork);
Thread t2 = new Thread(doWork);
t1.Start();
t2.Start();
t1.Join();
t2.Join();

Console.WriteLine(count);

















