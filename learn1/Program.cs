using System;
using OpenTK;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Windowing.GraphicsLibraryFramework;


namespace learn1
{

    internal class Program
    {
        public class Game : GameWindow {

            private float factor = 0;
            private float sinfactor = 0;

            private float frameTime = 0;
            private int fps = 0;


            public Game(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings) {

                //System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
                //start.FileName = @"C:\Users\Елена\source\repos\OpenGlLearns\learn1\Program.cs" + @"\Myprocesstostart.exe";
                //start.CreateNoWindow = true;
                //Console.SetWindowPosition(9, 3);

                Console.WriteLine("Start");

                Console.WriteLine(GL.GetString(StringName.Version));
                Console.WriteLine(GL.GetString(StringName.Vendor));
                Console.WriteLine(GL.GetString(StringName.Renderer));
                Console.WriteLine(GL.GetString(StringName.ShadingLanguageVersion));

                VSync = VSyncMode.On;
                CursorVisible = true;


            }

            protected override void OnLoad()
            {
      
                base.OnLoad();
                //GL.ClearColor(Color4.Black);


            }

            protected override void OnResize(ResizeEventArgs e)
            {
                base.OnResize(e);
            }

            protected override void OnUpdateFrame(FrameEventArgs args)
            {
                //Title = $"FPS: {args.Time}";
                frameTime += (float)args.Time;
                fps++;
                if (frameTime >= 1) {
                    Title = $"FPS: {fps}";
                    frameTime = 0;
                    fps=0;
                }

                //var key = KeyboardState;
                if (KeyboardState.IsKeyDown(Keys.Escape)) {
                    Console.WriteLine(Keys.Escape.ToString());
                    Close();
                }

                ////var key2 = KeyboardState;
                if (KeyboardState.IsKeyDown(Keys.Right))
                {
                    Console.WriteLine(Keys.Right.ToString());
                    DrawLine();
                }



                factor += 0.01f;
                sinfactor = (float)Math.Sin((double)factor);

                base.OnUpdateFrame(args);
            }

            private void DrawLine() {
                GL.Clear(ClearBufferMask.ColorBufferBit);
                //окантовка флага
                GL.Begin(PrimitiveType.LineLoop);
                //GL.Vertex2(ver);
                GL.Vertex2(-0.8f, 0.5f);
                GL.Vertex2(0.8f, 0.5f);
                GL.Vertex2(0.8f, -0.5f);
                GL.Vertex2(-0.8f, -0.5f);
                GL.End();

                SwapBuffers();
                
            }

            protected override void OnRenderFrame(FrameEventArgs args)
            {
                GL.ClearColor(255/255f, 190/255f, 252/255f, 255/255f);
                GL.Clear(ClearBufferMask.ColorBufferBit);


                ////GL.PointSize(5.0f);
                //GL.LineWidth(1.0f);
                //GL.Color3(1.0f, 0.54f, 0.0f);



                ////float[]ver = new float[] {0.5f, 0.3f, 0.5f, -0.3f, -0.5f, -0.3f, -0.5f, 0.3f };
                ////float[] ver = new float[] { 0.5f, 0.3f};
                ///
                //окантовка флага
                GL.Begin(PrimitiveType.LineLoop);
                //GL.Vertex2(ver);
                GL.Vertex2(-0.8f, 0.5f);
                GL.Vertex2(0.8f, 0.5f);
                GL.Vertex2(0.8f, -0.5f);
                GL.Vertex2(-0.8f, -0.5f);
                GL.End();

                //красная под звездой
                GL.LineWidth(5.5f);
                GL.Color3(1.0f, 0.0f, 0.0f);
                GL.Begin(PrimitiveType.Quads);
                //GL.Vertex2(ver);
                GL.Vertex2(-0.8f, 0.6f);
                GL.Vertex2(-0.2f, 0.6f);
                GL.Vertex2(-0.2f, -0.15f);
                GL.Vertex2(-0.8f, -0.15f);
                GL.End();


                //звезда
                GL.Color3(1.0f, 1.0f, 1.0f);
                GL.Begin(PrimitiveType.Polygon);
                //GL.Vertex2(ver);
                GL.Vertex2(-0.53f, 0.4f);
                GL.Vertex2(-0.5f, 0.5f);
                GL.Vertex2(-0.47f, 0.4f);
                GL.Vertex2(-0.36f, 0.4f);
                GL.Vertex2(-0.44f, 0.34f);
                GL.Vertex2(-0.4f, 0.24f);
                GL.Vertex2(-0.5f, 0.3f);
                GL.Vertex2(-0.6f, 0.24f);
                GL.Vertex2(-0.56f, 0.34f);
                GL.Vertex2(-0.64f, 0.4f);
                
                GL.End();


                //полоски-хуёски
                //первая пошла
                GL.Color3(39 / 255f, 158 / 255f, 63 / 255f);
                GL.Begin(PrimitiveType.Quads);
                //GL.Vertex2(ver);
                GL.Vertex2(-0.2f, 0.6f);
                GL.Vertex2(0.8f, 0.6f);
                GL.Vertex2(0.8f, 0.35f);
                GL.Vertex2(-0.2f, 0.35f);
                GL.End();

                //вторая пошла
                GL.Color3(210 / 255f, 216 / 255f, 43 / 255f);
                GL.Begin(PrimitiveType.Quads);
                //GL.Vertex2(ver);
                GL.Vertex2(-0.2f, 0.35f);
                GL.Vertex2(0.8f, 0.35f);
                GL.Vertex2(0.8f, 0.1f);
                GL.Vertex2(-0.2f, 0.1f);
                GL.End();


                //третья пошла
                GL.Begin(PrimitiveType.Quads);
                GL.Color3(39 / 255f, 158 / 255f, 63 / 255f);
                //GL.Vertex2(ver);
                GL.Vertex2(-0.2f, 0.1f);
                GL.Vertex2(0.8f, 0.1f);
                GL.Vertex2(0.8f, -0.15f);
                GL.Vertex2(-0.2f, -0.15f);
                GL.End();

                //четвёртая пошла
                
                GL.Begin(PrimitiveType.Quads);
                GL.Color3(210 / 255f, 216 / 255f, 43 / 255f);
                //GL.Vertex2(ver);
                GL.Vertex2(-0.8f, -0.15f);
                GL.Vertex2(0.8f, -0.15f);
                GL.Vertex2(0.8f, -0.4f);
                GL.Vertex2(-0.8f, -0.4f);
                GL.End();


                //пятая пошла
                GL.Color3(39 / 255f, 158 / 255f, 63 / 255f);
                GL.Begin(PrimitiveType.Quads);
                //GL.Vertex2(ver);
                GL.Vertex2(-0.8f, -0.4f);
                GL.Vertex2(0.8f, -0.4f);
                GL.Vertex2(0.8f, -0.6f);
                GL.Vertex2(-0.8f, -0.6f);
                GL.End();


                SwapBuffers();
                base.OnRenderFrame(args);
            }

            protected override void OnUnload()
            {
                base.OnUnload();
            }

        }


        static void Main(string[] args)
        {
            var nativeWinSettings = new NativeWindowSettings() {
                Size = new OpenTK.Mathematics.Vector2i(800, 600),
                Location = new Vector2i(900, 300),
                WindowBorder = WindowBorder.Resizable,
                WindowState = WindowState.Normal,
                StartVisible = true,
                StartFocused = true,
                //Title = "My Window",

                //APIVersion = new Version(3, 3),
                Flags = ContextFlags.Default,
                Profile = ContextProfile.Compatability,
                API = ContextAPI.OpenGL,

                NumberOfSamples = 0




            };



            using (Game game = new Game(GameWindowSettings.Default, nativeWinSettings)) {

                game.Run();
            }
        }
    }
}
