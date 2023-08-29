using System.Diagnostics;

namespace MenuWF.UIElements;

public static class Animator
{
    public static List<Animation> AnimationList = new List<Animation>();

    public static int Count()
    {
        return AnimationList.Count;
    }

    private static Thread AnimatorThread;

    private static double Interval;

    public static bool IsWork = false;

    public static void Start()
    {
        if (IsWork) return;

        IsWork = true;
        Interval = 14; // FPS ~66

        AnimatorThread = new Thread(AnimationInvoker)
        {
            IsBackground = true,
            Name = "UI Animation"
        };

        AnimatorThread.Start();
    }

    private static void AnimationInvoker()
    {
        while (IsWork)
        {
            AnimationList.RemoveAll(a => a == null || a.Status == Animation.AnimationStatus.Completed);

            Parallel.For(0, Count(), index =>
            {
                try
                {
                    AnimationList[index]?.UpdateFrame();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка Parallel: " + ex.Message);
                }
            });

            Thread.Sleep((int)Interval);
        }
    }

    public static void Request(Animation Anim, bool ReplaceIfExists = true)
    {
        if (AnimatorThread == null || IsWork == false)
            Start();

        Debug.WriteLine("Запуск анимации: " + Anim.ID + "| TargetValue: " + Anim.TargetValue);
        Anim.Status = Animation.AnimationStatus.Requested;

        try
        {
            Animation dupAnim = GetDuplicate(Anim);

            if (dupAnim != null)
                if (ReplaceIfExists == true)
                    dupAnim.Status = Animation.AnimationStatus.Completed;
                else
                    return;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка GetDuplicate: " + ex.Message);
        }

        AnimationList.Add(Anim);
    }

    private static Animation GetDuplicate(Animation Anim) => AnimationList.Find(a => a.ID == Anim.ID);
}
