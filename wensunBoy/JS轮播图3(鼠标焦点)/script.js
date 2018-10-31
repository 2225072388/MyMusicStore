window.onload = function () {
    //var slider = document.getElementById('slider');
    var ul = document.getElementById('nav_ul');
    var ol = document.getElementById('nav_ol');
    var ols = ol.children;

    var lea=0;
    var tar=0;

    for(var i=0;i<ols.length;i++){
        //每个li的所引号
        ols[i].index=i;
        ols[i].onmouseover=function(){
            for(var j=0;j<ols.length;j++){
                ols[j].className='';//去掉所有的class='current';
            }
            this.className='current';
            tar=-this.index*490;//目标位置=当前index*图片宽度
        }
    }
    //动画 每20ms left值如何变化
    setInterval(function(){
        lea=lea+(tar-lea)/10;
        ul.style.left=lea+'px';
    },20)
}