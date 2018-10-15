using Tizen.Wearable.CircularUI.Forms.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;
using Xamarin.Forms.StyleSheets;

namespace Samples.Tizen
{
    class Program : FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();

            var app = new App();
            try
            {
                if (Device.Idiom == TargetIdiom.TV)
                    app.Resources.Add(StyleSheet.FromAssemblyResource(GetType().Assembly, "Samples.Tizen.res.tizen_style.css"));
            }
            catch
            {
            }

            LoadApplication(app);
        }

        static void Main(string[] args)
        {
            var app = new Program();

            if (Device.Idiom == TargetIdiom.TV)
            {
                global::Tizen.TV.UIControls.Forms.Renderer.UIControls.PreInit();
                Forms.Init(app);
                global::Tizen.TV.UIControls.Forms.Renderer.UIControls.PostInit();
            }
            else
            {
                Forms.Init(app);
                if (Device.Idiom == TargetIdiom.Watch)
                    FormsCircularUI.Init();
            }
            app.Run(args);
        }
    }
}
