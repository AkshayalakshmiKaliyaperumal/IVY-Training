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

const a5=ages.sort((a,b)=>a-b)
console.log(a5);

const a6=ages.sort((c,d)=>c-d)
console.log(a6);


//ages.sort(function(a,b){return a - b});
// const a5=ages.sort((a,b)=>(a.ages-b.ages))
// console.log(a5);
// ages.sort(function(a,b){return b-a});
// const a6=ages.sort((a,b)=>(b.ages - a.ages))
// console.log(a6);

  //1 . for each
//   for(let i=0; i<companies.length;i++)
// {
//   console.log(companies[i]);
  
// }  

// companies.forEach(function(Company){
//   console.log(Company.name);
  
// })


// 2. Filter


// let vote=[];

// for(let i=0; i<ages.length;i++){
//   if(ages[i]>=18){
//     vote.push(ages[i]);
//     console.log(vote)
//   }
// }


// const vote=ages.filter(function(age){
//   if(age>=18){
//     return true
//   }
// })
// console.log(vote);


// const vote=ages.filter(age=>age>=18);
// console.log(vote);


// 3. Map

// const testmap=companies.map(function(Company){
//   return `${Company.name} [${Company.start}-${Company.end}]`;
// })
// console.log(testmap);


// const testmap=companies.map(Company=>`${Company.name} [${Company.start}-${Company.end}]`)
// console.log(testmap);


// 4. Sort

// const sortedcompanies=companies.sort(function(c1, c2){
//   if(c1.start>c2.start){
//     return 1;
//   } else{
//     return -1
//   }
// })

// console.log(sortedcompanies);


// const sortedcompanies=companies.sort((a,b)=>(a.start>b.start ? 1 : -1))
// console.log(sortedcompanies);

// 5. Reduce

// let ageSum=0;
// for(let i=0;i<ages.length;i++){
//   ageSum+=ages[i]
// }

// console.log(ageSum);


// const ageSum=ages.reduce(function(total,age){
//   return total+age
// },0);

// console.log(ageSum);


// const ageSum=ages.reduce((total,age)=>total+age,5);
// console.log(ageSum);


// const combined=ages
// .map(age=>age*20)
// .filter(age=>age>=40)
// .sort((a,b)=>a-b)
// .reduce((a,b)=>a+b)
// console.log(combined);



// function greet(callback){
//   console.log("hello");
//   if(callback){
//     callback()
//   }

// }

// function h1(){
//   console.log("welcome");
// }

// greet(function(){
//   console.log('welcome');
// })


// function multiply(fact)
//   {
//    return x=>x*fact 
//   }
  

// let a =multiply(2);
// let b=multiply(4);



// function multipy(x,y){
//   return x*y;
// }









