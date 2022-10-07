const companies= [
    {name: "Company One", category: "Finance", start: 1981, end: 2004},
    {name: "Company Two", category: "Retail", start: 1992, end: 2008},
    {name: "Company Three", category: "Auto", start: 1999, end: 2007},
    {name: "Company Four", category: "Retail", start: 1989, end: 2010},
    {name: "Company Five", category: "Technology", start: 2009, end: 2014},
    {name: "Company Six", category: "Finance", start: 1987, end: 2010},
    {name: "Company Seven", category: "Auto", start: 1986, end: 1996},
    {name: "Company Eight", category: "Technology", start: 2011, end: 2016},
    {name: "Company Nine", category: "Retail", start: 1981, end: 1989}
];
  
const ages = [33, 12, 20, 16, 5, 54, 21, 44, 61, 13, 15, 45, 25, 64, 32];

var a1=companies.filter(company=>(company.start>=1980 && company.start<=1989));
console.log(a1);  

var a2=companies.filter(company=>company.category=="Retail");
console.log(a2);

var a3=companies.filter(company=>(company.end - company.start)>=10);
console.log(a3);  

const a4=ages.map(age=>age*20)
console.log(a4);

const a5=ages.sort((a,b)=>(a-b));
console.log(a5);

const a6=ages.sort((a,b)=>(b-a));
console.log(a6);
