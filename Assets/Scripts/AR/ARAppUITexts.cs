using UnityEngine;

public static class ARAppUITexts
{
    public const string Version = "1.4";

    public static string VersionString;
    public static string DateDisplayCulture;

    // in case one cannot connect to the server
    public static string ButtonTryAgain;
    public static string ButtonNoARContinue;
    public static string ButtonRefresh;

    // button to join a channel
    public static string ButtonJoin;

    // button to get more info
    public static string ButtonMoreInformation;

    // text that might be displayed on startup
    public static string PreMenuCannotConnect;
    public static string PreMenuNotCompatibleApple;
    public static string PreMenuNotCompatibleAndroid;
    public static string PreMenuAppOutOfDate;
    public static string PreMenuARNeedsInstall;

    public static string MainMenuAvailableChannelsLabel;
    public static string MainMenuInformationLabel;

    public static string MainMenuChannelInformationError;

    public static string MainMenuStatusOnline;
    public static string MainMenuStatusOffline;

    // status messages displayed in the AR experience
    public static string ARStatusWaitingForTracking;
    public static string ARStatusTapOnCube;

    public static string ARStatusInsufficientLight;
    public static string ARStatusInsufficientFeatures;
    public static string ARStatusGrantCameraPermissions;

    private static bool languageWasSet = false;

    static public void SwitchLanguage() {
        if(languageWasSet) return;

        if(IsDutch()) {
            SetNL();
        } else {
            SetEN();
        }

        languageWasSet = true;
    }

    static public bool IsDutch() {
        return Application.systemLanguage == SystemLanguage.Dutch;
    }

    static public void PopulateAbout(AboutPopulator populator) {
        if(IsDutch()) {
            PopulateAboutNL(populator);
        } else {
            PopulateAboutEN(populator);
        }
    }




    // ENGLISH




    static private void SetEN() {

        VersionString = "Version " + Version;
        DateDisplayCulture = "en-GB";

        // in case one cannot connect to the server
        ButtonTryAgain = "Try again!";
        ButtonNoARContinue = "Continue";
        ButtonRefresh = "Refresh";

        // button to join a channel
        ButtonJoin = "Start";

        // button to get more info
        ButtonMoreInformation = "More Information";

        // text that might be displayed on startup
        PreMenuCannotConnect = "Cannot connect to ARquatic server. Please connect to the Internet or try again later.";
        PreMenuNotCompatibleApple = "Unfortunately ARKit is not supported on your device. Instead of showing you the visuals in Augmented Reality they will be displayed for you in a virtual scene on your screen.";
        PreMenuNotCompatibleAndroid = "Unfortunately ARCore is not supported on your device. Instead of showing you the visuals in Augmented Reality they will be displayed for you in a virtual scene on your screen.";
        PreMenuAppOutOfDate = "Your ARquatic app is out of date. Please update your app in order to experience ARquatic.";
        PreMenuARNeedsInstall = "In order to run this app ARCore needs to be installed from the Play Store. Your device should display a prompt for that.";

        MainMenuAvailableChannelsLabel = "Available Channels";
        MainMenuInformationLabel = "Information";

        MainMenuChannelInformationError = "Could not refresh channel information ...";

        MainMenuStatusOnline = "online";
        MainMenuStatusOffline = "offline";

        // status messages displayed in the AR experience
        ARStatusWaitingForTracking = "Move your device slowly to establish tracking!";
        ARStatusTapOnCube = "Tap to place the AR!";

        ARStatusInsufficientLight = "Insufficient light in your environment to establish stable tracking.";
        ARStatusInsufficientFeatures = "Insufficient optical features in your view to establish stable tracking.";
        ARStatusGrantCameraPermissions = "Camera permissions are required for this AR experience. Please exit and try again!";

    } 

    static private void PopulateAboutEN(AboutPopulator x)
    {
        x.Headline("About");
        x.Paragraph("The ARquatic app creates the Augmented Reality (AR) visuals during an 'ARquatic Live' experience. At showtime, simply follow the app prompts to watch the AR underwater world unfold before your eyes.");
        x.Paragraph("The 'ARquatic Live' experience is a CodeKlavier project. A key aspect of this experience is that the AR visuals are built on L-systems that are coded, (yes coded!), with the help of the CodeKlavier, by the pianist in real-time during the show. 'ARquatic Live' is an audio-visual experience with the same pianist and a collaborating laptop musician, performing music live.");
        x.Paragraph("Keep reading or visit our website for more info about how 'ARquatic Live' works or ask the host!");
        x.LinkButton("ARquatic Live", "https://codeklavier.space/arquatic");

        x.ParagraphDivider();

        x.Headline("Credits");
        x.Paragraph("Anne Veinberg - piano\nFelipe Ignacio Noriega - live electronics\nPatrick Borgeat - visuals, app development");

        x.ParagraphDivider();

        x.Headline("Artistic Concept");
        x.Paragraph("Codeklavier's 'ARquatic Live' is an audio and Augmented Reality experience where the live music provides the DNA of the underwater world unfolding before your eyes. Full of speculative, fantasy structures artificially built from L-system rules, �ARquatic Live� superimposes unusual aquatic inspired objects in everyday environments. Whether you attend a live performance or tune in at home for a streamed experience, the juxtaposition from the surroundings with the AR objects will stimulate one�s imagination by highlighting the contrasting beauty of the natural and the unnatural world.");

        x.ParagraphDivider();

        x.Headline("Motivation");
        x.Paragraph("Our inspiration for working with L-systems comes primarily from its roots in nature and organic growth which we would like to bring to the musical and programming paradigms. Whilst L-systems are already widely used in generative art and music, we are interested in exploring how this simple model can be used by the piano coder to express complex structures and how its rules will shape the pianistic improvisation. Furthermore, Lindenmayer�s work was done here at the University of Utrecht in 1968 and building upon it through artistic exploration, makes the Netherlands a particularly special location for the presentation of this project.");

        x.ParagraphDivider();

        x.Headline("Privacy");
        x.ParagraphDivider();
        x.LinkButton("ARquatic Privacy Policy", "https://codeklavier.space/privacy");
#if UNITY_ANDROID
        x.ParagraphDivider();
        x.Paragraph("This application runs on Google Play Services for AR (ARCore), which is provided by Google and governed by the Google Privacy Policy.");
        x.LinkButton("Google Privacy Policy", "https://policies.google.com/privacy");
#endif
    }



    // DUTCH



    static private void SetNL() {

        VersionString = "Version " + Version;
        DateDisplayCulture = "nl-NL";

        // in case one cannot connect to the server
        ButtonTryAgain = "Try again!";
        ButtonNoARContinue = "Continue";
        ButtonRefresh = "Refresh";

        // button to join a channel
        ButtonJoin = "NL Start NL";

        // button to get more info
        ButtonMoreInformation = "More Information";

        // text that might be displayed on startup
        PreMenuCannotConnect = "Cannot connect to ARquatic server. Please connect to the Internet or try again later.";
        PreMenuNotCompatibleApple = "Unfortunately ARKit is not supported on your device. Instead of showing you the visuals in Augmented Reality they will be displayed for you in a virtual scene on your screen.";
        PreMenuNotCompatibleAndroid = "Unfortunately ARCore is not supported on your device. Instead of showing you the visuals in Augmented Reality they will be displayed for you in a virtual scene on your screen.";
        PreMenuAppOutOfDate = "Your ARquatic app is out of date. Please update your app in order to experience ARquatic.";
        PreMenuARNeedsInstall = "In order to run this app ARCore needs to be installed from the Play Store. Your device should display a prompt for that.";

        MainMenuAvailableChannelsLabel = "Available Channels";
        MainMenuInformationLabel = "Information";

        MainMenuChannelInformationError = "Could not refresh channel information ...";

        MainMenuStatusOnline = "online";
        MainMenuStatusOffline = "offline";

        // status messages displayed in the AR experience
        ARStatusWaitingForTracking = "Move your device slowly to establish tracking!";
        ARStatusTapOnCube = "Tap to place the AR!";

        ARStatusInsufficientLight = "Insufficient light in your environment to establish stable tracking.";
        ARStatusInsufficientFeatures = "Insufficient optical features in your view to establish stable tracking.";
        ARStatusGrantCameraPermissions = "Camera permissions are required for this AR experience. Please exit and try again!";

    } 

    static private void PopulateAboutNL(AboutPopulator x)
    {
        /* to translate

        x.Headline("About");
        x.Paragraph("The ARquatic app creates the Augmented Reality (AR) visuals during an 'ARquatic Live' experience. At showtime, simply follow the app prompts to watch the AR underwater world unfold before your eyes.");
        x.Paragraph("The 'ARquatic Live' experience is a CodeKlavier project. A key aspect of this experience is that the AR visuals are built on L-systems that are coded, (yes coded!), with the help of the CodeKlavier, by the pianist in real-time during the show. 'ARquatic Live' is an audio-visual experience with the same pianist and a collaborating laptop musician, performing music live.");
        x.Paragraph("Keep reading or visit our website for more info about how 'ARquatic Live' works or ask the host!");
        x.LinkButton("ARquatic Live", "https://codeklavier.space/arquatic");

        x.ParagraphDivider();

        x.Headline("Credits");
        x.Paragraph("Anne Veinberg - piano\nFelipe Ignacio Noriega - live electronics\nPatrick Borgeat - visuals, app development");

        x.ParagraphDivider();

        x.Headline("Artistic Concept");
        x.Paragraph("Codeklavier's 'ARquatic Live' is an audio and Augmented Reality experience where the live music provides the DNA of the underwater world unfolding before your eyes. Full of speculative, fantasy structures artificially built from L-system rules, �ARquatic Live� superimposes unusual aquatic inspired objects in everyday environments. Whether you attend a live performance or tune in at home for a streamed experience, the juxtaposition from the surroundings with the AR objects will stimulate one�s imagination by highlighting the contrasting beauty of the natural and the unnatural world.");

        x.ParagraphDivider();

        x.Headline("Motivation");
        x.Paragraph("Our inspiration for working with L-systems comes primarily from its roots in nature and organic growth which we would like to bring to the musical and programming paradigms. Whilst L-systems are already widely used in generative art and music, we are interested in exploring how this simple model can be used by the piano coder to express complex structures and how its rules will shape the pianistic improvisation. Furthermore, Lindenmayer�s work was done here at the University of Utrecht in 1968 and building upon it through artistic exploration, makes the Netherlands a particularly special location for the presentation of this project.");

        x.ParagraphDivider();

        x.Headline("Privacy");
        x.ParagraphDivider();
        x.LinkButton("ARquatic Privacy Policy", "https://codeklavier.space/privacy");
#if UNITY_ANDROID
        x.ParagraphDivider();
        x.Paragraph("This application runs on Google Play Services for AR (ARCore), which is provided by Google and governed by the Google Privacy Policy.");
        x.LinkButton("Google Privacy Policy", "https://policies.google.com/privacy");
#endif
    */
    }
}
