using TaskMinimum;

QueueM<int> queue = new QueueM<int>();
ArrayMinimumDeque<int> dequeM = new ArrayMinimumDeque<int>();
ArrayMinimumQueue<int> queueM = new ArrayMinimumQueue<int>();
int[] arr = new int[20];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1,100);
    Console.WriteLine(arr[i]);
}
var k = queueM.GetMinimum(5, arr);
int v = 0;
