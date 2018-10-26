window.onload=function(){
    document.body.onkeydown=function(evt){
        var e= evt? evt:window.event;
        switch(e.keyCode){
            case 87:
            document.getElementById('img').style.top="10px";
            break;
            case 65:
            document.getElementById('img').style.top="10px";
            break;
            case 83:
            document.getElementById('img').style.top="10px";
            break;
            case 68:
            document.getElementById('img').style.top="10px";
            break;
        }
    }
}