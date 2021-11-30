

    var element = document.getElementById("Slider");
    var duration = 3000;
    var hidden_time = 2000;
    var visible_time = 2000;

    var running = 0;
    var image_count = 1;

    var image_size = element.getElementsByTagName('div').length;

    function SetOpacity(Opacity)
    {
        element.style.opacity = Opacity;
    }

    function StartFade()
    {
        if (running != 1)
        {
            running = 1;
            FadeOut();
        }
    }

    function FadeIn()
    {
        for (i = 0; i <= 1; i += 0.01)
        {
            setTimeout("SetOpacity(" + i + ")", i * duration);
        }

        if (image_count == image_size)
        {
            image_count = 1;
            document.getElementById("image" + image_count).style.display = "block";
            document.getElementById("image" + image_size).style.display = "none";
        }
        else
        {
            document.getElementById("image" + (image_count + 1)).style.display = "block";
            document.getElementById("image" + image_count).style.display = "none";
            image_count = image_count+1;
        }

        setTimeout("FadeOut()", (duration + visible_time));
    }

    function FadeOut()
    {
        for (i = 0; i <= 1; i += 0.01)
        {
            setTimeout("SetOpacity(" + (1 - i) + ")", i * duration);
        }

        setTimeout("FadeIn()", (duration + hidden_time));
    } 

    StartFade();
