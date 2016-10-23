        private void OnBufferChanged(object sender, TextContentChangedEventArgs e)
        {
            //Make a list of all comments that have a span of at least one character after applying the change. There is no need to raise a changed event for the deleted adornments. The adornments are deleted only if a text change would cause the view to reformat the line and discard the adornments.
            IList<CommentAdornment> keptComments = new List<CommentAdornment>(this.comments.Count);

            foreach (CommentAdornment comment in this.comments)
            {
                Span span = comment.Span.GetSpan(e.After);
                //if a comment does not span at least one character, its text was deleted.
                if (span.Length != 0)
                {
                    keptComments.Add(comment);
                }
            }

            this.comments = keptComments;
        }