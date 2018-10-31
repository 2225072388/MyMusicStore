window.onload = function () {
    // var $pic ul=('.picul') = document.getElementById('slider');
     var img = document.getElementById('pic_img');
     var ol = document.getElementById('nav_ol');
     var ols = ol.children;
 
     var lea = 0;
     var tar = 0;
 
     for (var i = 0; i < ols.length; i++) {
         //每个li的所引号
         ols[i].index = i;
         ols[i].onmouseover = function () {
             for (var j = 0; j < ols.length; j++) {
                 ols[j].className = '';//去掉所有的class='current';
             }
             this.className = 'current';
             tar = -this.index * 525;//目标位置=当前index*图片宽度
         }
     }
     //动画 每20ms left值如何变化
     setInterval(function () {
         lea = lea + (tar - lea) / 10;
         img.style.left = lea + 'px';
     }, 20)

     
    //动画 每20ms left值如何变化
    setInterval(function () {
        lea = lea + (tar - lea) / 10;
        img.style.left = lea + 'px';
    }, 20)
    var curIndex = 0;
    //时间间隔(单位毫秒)，每秒钟显示一张，数组共有5张图片放在Photos文件夹下。
    var timeInterval = 1000;
    var arr = new Array();
    arr[0] = "images/1.jpg";
    arr[1] = "images/2.jpg";
    arr[2] = "images/3.jpg";
    arr[3] = "images/4.jpg";
    arr[4] = "images/5.jpg";
    setInterval(changeImg, timeInterval);
    function changeImg() {
        var obj = document.getElementById("obj");
        if (curIndex == arr.length - 1) {
            curIndex = 0;
        }
        else {
            curIndex += 1;
        }
        obj.src = arr[curIndex];
    }
 }