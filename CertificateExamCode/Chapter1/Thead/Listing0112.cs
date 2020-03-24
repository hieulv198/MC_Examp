namespace CertificateExamCode.Chapter1.Thead
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    ///     Attaching child tasks to a parent task
    /// </summary>
    public class Listing0112
    {
        public static void DoSample()
        {
            var parent = Task.Run(
                () =>
                    {
                        var results = new int[3];
                        var tf = new TaskFactory(
                            TaskCreationOptions.AttachedToParent,
                            TaskContinuationOptions.ExecuteSynchronously);

                        tf.StartNew(
                            () =>
                                {
                                    Console.WriteLine(Task.CurrentId);
                                    return results[0] = 0;
                                });
                        tf.StartNew(
                            () =>
                                {
                                    Console.WriteLine(Task.CurrentId);
                                    return results[1] = 1;
                                });
                        tf.StartNew(
                            () =>
                                {
                                    Console.WriteLine(Task.CurrentId);
                                    return results[2] = 2;
                                });

                        return results;
                    });

            var finalTask = parent.ContinueWith(
                task =>
                    {
                        foreach (var i in task.Result) Console.WriteLine($"Result {i}");
                    });

            finalTask.Wait();
        }
    }
}