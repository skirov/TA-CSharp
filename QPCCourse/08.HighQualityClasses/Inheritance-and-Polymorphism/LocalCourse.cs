// <copyright file="LocalCourse.cs" company="Telerik academy">
// Telerik academy homework for high quality classes - Task 03.SoftwareAcademy
// </copyright>
namespace SoftwareAcademy
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents a local software academy course.
    /// </summary>
    public class LocalCourse : Course
    {
        /// <summary>
        /// The name of the lab where the course is held.
        /// </summary>
        private string lab;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
        /// </summary>
        /// <param name="name">The name of the course.</param>
        /// <param name="teacherName">The name of the teacher.</param>
        /// <param name="students">A list of students attending the course.</param>
        /// <param name="lab">The name of the lab.</param>
        public LocalCourse(string name, string teacherName, IList<string> students, string lab)
            : base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
        /// </summary>
        /// <param name="name">The name of the course.</param>
        public LocalCourse(string name)
            : this(name, null, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
        /// </summary>
        /// <param name="name">The name of the course.</param>
        /// <param name="teacherName">The name of the teacher.</param>
        public LocalCourse(string name, string teacherName)
            : this(name, teacherName, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
        /// </summary>
        /// <param name="name">The name of the course.</param>
        /// <param name="teacherName">The name of the teacher.</param>
        /// <param name="students">A list of students attending the course.</param>
        public LocalCourse(string name, string teacherName, IList<string> students)
            : this(name, teacherName, students, null)
        {
        }

        #endregion

        /// <summary>
        /// Gets or sets the name of the course lab.
        /// </summary>
        /// <value>Gets or sets the lab field.</value>
        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                this.lab = value;
            }
        }

        /// <summary>
        /// Returns the string representation of the course info -
        /// its base class info, plus the lab name.
        /// </summary>
        /// <returns>A string which represents the local course info.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { ");
            result.Append(base.ToString());

            if (this.Lab != null)
            {
                result.AppendFormat("; Lab = {0}", this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}