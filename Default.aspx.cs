using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ShowTrackerServiceReference.VenueShowServiceClient db = new ShowTrackerServiceReference.VenueShowServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadDropDownSA();
            LoadDropDownSV();
        }
    }
    protected void DropDownListShowArtists_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGridSA();
    }

    protected void LoadDropDownSA()
    {
        string[] shows = db.GetArtists();
        DropDownListShowArtists.DataSource = shows;
        DropDownListShowArtists.DataBind();
        DropDownListShowArtists.Items.Insert(0, "Choose an Artist");
    }

    protected void FillGridSA()
    {
        string artist = DropDownListShowArtists.SelectedItem.Text;
        ShowTrackerServiceReference.ShowLite[] artists = db.GetShowArtists(artist);
        GridViewShowArtists.DataSource = artists;
        GridViewShowArtists.DataBind();
    }

    protected void DropDownListShowVenues_SelectedIndexChanged1(object sender, EventArgs e)
    {
        FillGridSV();
    }

    protected void LoadDropDownSV()
    {
        string[] shows = db.GetVenues();
        DropDownListShowVenues.DataSource = shows;
        DropDownListShowVenues.DataBind();
        DropDownListShowVenues.Items.Insert(0, "Choose a Venue");
    }

    protected void FillGridSV()
    {
        string venue = DropDownListShowVenues.SelectedItem.Text;
        ShowTrackerServiceReference.ShowLite1[] venues = db.GetShowVenues(venue);
        GridViewShowVenues.DataSource = venues;
        GridViewShowVenues.DataBind();
    }

}