﻿using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
#if COM_INTEROP
[assembly: AssemblyTitle("ACBr.Net.NFSe")]
[assembly: AssemblyDescription("ACBrNFSe Library")]
[assembly: AssemblyProduct("ACBr.Net NFSe ActiveX")]
[assembly: TypeLibVersion(109, 23)]
#else
[assembly: AssemblyTitle("ACBr.Net.NFSe")]
[assembly: AssemblyDescription("ACBrNFSe Library")]
[assembly: AssemblyProduct("ACBr.Net NFSe")]
#endif

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("ACBr.Net")]
[assembly: AssemblyCopyright("Copyright © Grupo ACBr.Net 2014 - 2016")]
[assembly: AssemblyTrademark("Grupo ACBr.Net https://acbrnet.github.io")]
[assembly: AssemblyKeyFile(@"../../../acbr.net.snk")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
#if COM_INTEROP
[assembly: ComVisible(true)]
#else
[assembly: ComVisible(false)]
#endif

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("c60c8c70-1ab5-4e28-85de-7bd747305396")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.9.0.0")]
[assembly: AssemblyFileVersion("0.9.0.0")]