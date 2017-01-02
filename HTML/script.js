function S(obj)
 {

        var a1=obj.s1.value;

        var a2=obj.s2.value;

        var a3=obj.s3.value;

        var s,p=a1*1+a2*1+a3*1;

        var n=document.createElement("div");

        obj.appendChild(n);

        n.innerHTML="Периметр треугольника = "+p;

        p=p/2;s=Math.sqrt(p*(p-a1)*(p-a2)*(p-a3));

        var nn=document.createElement("span");

        obj.appendChild(nn);

        nn.innerHTML="Площадь треугольника = "+s;

  }
function s2(o,oo)
 {

       var x=Number(oo);

       y=eval(o);

        return y;

 }