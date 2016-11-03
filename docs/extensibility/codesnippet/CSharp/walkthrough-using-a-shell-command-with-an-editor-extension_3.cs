        private void DrawComment(CommentAdornment comment)
        {
            SnapshotSpan span = comment.Span.GetSpan(this.view.TextSnapshot);
            Geometry g = this.view.TextViewLines.GetMarkerGeometry(span);

            if (g != null)
            {
                //Find the rightmost coordinate of all the lines that intersect the adornment.
                double maxRight = 0.0;
                foreach (ITextViewLine line in this.view.TextViewLines.GetTextViewLinesIntersectingSpan(span))
                    maxRight = Math.Max(maxRight, line.Right);

                //Create the visualization.
                CommentBlock block = new CommentBlock(maxRight, this.view.ViewportRight, g, comment.Author, comment.Text);

                //Add it to the layer.
                this.layer.AddAdornment(span, comment, block);
            }
        }