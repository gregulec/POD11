using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POD11
{
    class Wiz
    {
        private Bitmap input;
        private Bitmap part1;
        private Bitmap part2;
        private Bitmap output;
        private Color black;
        private Color white;

        public Wiz(string path)
        {
            input = new Bitmap(path);
            part1 = new Bitmap(2 * input.Width, input.Height);
            part2 = new Bitmap(2 * input.Width, input.Height);
            output = new Bitmap(2 * input.Width, input.Height);
            black = Color.FromArgb(0, 0, 0);
            white = Color.FromArgb(255, 255, 255);
        }

        public void encrypt()
        {
            Random r = new Random();
            for (int i = 0; i < input.Width; i++)
            {
                for (int j = 0; j < input.Height; j++)
                {
                    Color pixelInput = input.GetPixel(i, j);
                    int value = r.Next(0, 2);
                    if (pixelInput==white)
                    {
                        if (value == 1)
                        {
                            part1.SetPixel(2 * i, j, black);
                            part1.SetPixel(2 * i + 1, j, white);
                            part2.SetPixel(2 * i, j, black);
                            part2.SetPixel(2 * i + 1, j, white);
                        }
                        else
                        {
                            part1.SetPixel(2 * i, j, white);
                            part1.SetPixel(2 * i + 1, j, black);
                            part2.SetPixel(2 * i, j, white);
                            part2.SetPixel(2 * i + 1, j, black);
                        }
                    }
                    if (pixelInput==black)
                    {
                        if (value == 1)
                        {
                            part1.SetPixel(2 * i, j, black);
                            part1.SetPixel(2 * i + 1, j, white);
                            part2.SetPixel(2 * i, j, white);
                            part2.SetPixel(2 * i + 1, j, black);
                        }
                        else
                        {
                            part1.SetPixel(2 * i, j, white);
                            part1.SetPixel(2 * i + 1, j, black);
                            part2.SetPixel(2 * i, j, black);
                            part2.SetPixel(2 * i + 1, j, white);
                        }
                    }
                }
            }  
        }

        public void decrypt()
        {
            for (int i = 0; i < output.Width; i++)
            {
                for (int j = 0; j < output.Height; j++)
                {
                    Color pixelPart1 = part1.GetPixel(i, j);
                    Color pixelPart2 = part2.GetPixel(i, j);
                    if (pixelPart1==white && pixelPart2==white) output.SetPixel(i, j, white);
                    if (pixelPart1==black && pixelPart2==black) output.SetPixel(i, j, black);
                    if (pixelPart1==white && pixelPart2==black) output.SetPixel(i, j, black);
                    if (pixelPart1==black && pixelPart2==white) output.SetPixel(i, j, black);
                }
            }
            output.Save(@"C:\Users\Public\output.bmp");
        }

        public string getPathPart1()
        {
            part1.Save(@"C:\Users\Public\part1.bmp");
            return @"C:\Users\Public\part1.bmp";
        }

        public string getPathPart2()
        {
            part2.Save(@"C:\Users\Public\part2.bmp");
            return @"C:\Users\Public\part2.bmp";
        }

        public string getPathOutput()
        {
            return @"C:\Users\Public\output.bmp";
        }
    }
}
