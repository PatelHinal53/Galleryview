using Android.Content;
using Android.Views;
using Android.Widget;


namespace Galleryview
{
    

    public class ImageAdapter : BaseAdapter
    {
        Context c;

        public ImageAdapter(Context c)
        {
            this.c = c;
        }

        public override int Count { get { return thumbIds.Length; } }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        [System.Obsolete]
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView i = new ImageView(c);

            i.SetImageResource(thumbIds[position]);
            i.LayoutParameters = new Gallery.LayoutParams(650, 750);
            i.SetScaleType(ImageView.ScaleType.FitXy);

            return i;
        }

        // references to our images
        int[] thumbIds = {
            
            Resource.Drawable.flow,
            Resource.Drawable.flowers,
            Resource.Drawable.Royalty,
            Resource.Drawable.yellow,
            Resource.Drawable.sakae
     };
    }
    
}