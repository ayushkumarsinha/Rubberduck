﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Vbe.Interop;

namespace Rubberduck.Extensions
{
    [ComVisible(false)]
    public static class ProjectExtensions
    {
        public static IEnumerable<string> ComponentNames(this VBProject project)
        {
            foreach (VBComponent component in project.VBComponents)
            {
                yield return component.Name;
            }
        }

        public static void EnsureReferenceToAddInLibrary(this VBProject project)
        {
            var referencePath = System.IO.Path.ChangeExtension(System.Reflection.Assembly.GetExecutingAssembly().Location, ".tlb");

            List<Reference> existing = project.References.Cast<Reference>().Where(r => r.Name == "Rubberduck").ToList();
            foreach (Reference reference in existing)
            {
                project.References.Remove(reference);
            }

            if (project.References.Cast<Reference>().All(r => r.FullPath != referencePath))
            {
                project.References.AddFromFile(referencePath);
            }
        }

        /// <summary>
        /// Exports all code modules in the VbProject to a destination directory. Files are given the same name as their parent code module name and file extensions are based on what type of code module it is.
        /// </summary>
        /// <param name="project">The <see cref="VbProject"/> to be exported to source files.</param>
        /// <param name="directoryPath">The destination directory path.</param>
        public static void ExportSourceFiles(this VBProject project, string directoryPath)
        {
            foreach (VBComponent component in project.VBComponents)
            {
                component.ExportAsSourceFile(directoryPath);
            }
        }

        /// <summary>
        /// Removes All VbComponents from the VbProject.
        /// </summary>
        /// <remarks>
        /// Document type Components cannot be physically removed from a project through the VBE.
        /// Instead, the code will simply be deleted from the code module.
        /// </remarks>
        /// <param name="project"></param>
        public static void RemoveAllComponents(this VBProject project)
        {
            foreach (VBComponent component in project.VBComponents)
            {
                project.VBComponents.RemoveSafely(component);
            }
        }

        //todo: Implement ImportSourceFiles. Don't import .frx files. DocClasses need to imported by writing to module from file.
    }
}
