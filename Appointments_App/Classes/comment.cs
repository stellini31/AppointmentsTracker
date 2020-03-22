using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments_App.Classes
{
    public class comment
    {
        private string commentText;
        private int commentTypeId;
        private DateTime dateAdded;

        public comment(string commentText, int commentTypeId, DateTime dateAdded)
        {
            this.CommentText = commentText;
            this.CommentTypeId = commentTypeId;
            this.DateAdded = dateAdded;
        }

        public string CommentText { get => commentText; set => commentText = value; }
        public int CommentTypeId { get => commentTypeId; set => commentTypeId = value; }
        public DateTime DateAdded { get => dateAdded; set => dateAdded = value; }
    }
}
