﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pastebook.Models
{
    public class UserCommentModel
    {
        public UserModel User = new UserModel();
        public CommentModel Comment = new CommentModel();
    }
}