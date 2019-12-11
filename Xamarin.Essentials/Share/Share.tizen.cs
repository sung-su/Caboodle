using System;
using System.Threading.Tasks;
using Tizen.Applications;

namespace Xamarin.Essentials
{
    public static partial class Share
    {
        static Task PlatformRequestAsync(ShareTextRequest request)
        {
            Permissions.EnsureDeclared<Permissions.LaunchApp>();

            var appControl = new AppControl
            {
                Operation = AppControlOperations.ShareText,
            };

            if (!string.IsNullOrEmpty(request.Text))
                appControl.ExtraData.Add(AppControlData.Text, request.Text);
            if (!string.IsNullOrEmpty(request.Uri))
                appControl.ExtraData.Add(AppControlData.Url, request.Uri);
            if (!string.IsNullOrEmpty(request.Subject))
                appControl.ExtraData.Add(AppControlData.Subject, request.Subject);
            if (!string.IsNullOrEmpty(request.Title))
                appControl.ExtraData.Add(AppControlData.Title, request.Title);

            AppControl.SendLaunchRequest(appControl);

            return Task.CompletedTask;
        }

        static Task PlatformRequestAsync(ShareFileRequest request)
        {
            Permissions.EnsureDeclared<Permissions.LaunchApp>();

            var appControl = new AppControl
            {
                Operation = AppControlOperations.ShareText,
            };

            if (!string.IsNullOrEmpty(request.File.FullPath))
                appControl.ExtraData.Add(AppControlData.Path, request.File.FullPath);
            if (!string.IsNullOrEmpty(request.Title))
                appControl.ExtraData.Add(AppControlData.Title, request.Title);

            AppControl.SendLaunchRequest(appControl);

            return Task.CompletedTask;
        }
    }
}
