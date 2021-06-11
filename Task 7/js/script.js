// _______________________Task 1______________________________

alert('На этом сайте действуют подсказки при наведении.');
let buttonHandler1 = document.querySelector('#handler');
let str = document.querySelector('#inputText');
let res = document.querySelector('#outputResult');

buttonHandler1.onclick = function (event) {
   event.preventDefault();

   var ignore = ["?", "!", ":", ";", ",", ".", " ", "\t", "\r"];
   var letters = {}, result;
   var words = str.value.split(' ');

   words.forEach(function (word) {
      word.split('').forEach(function (letter, i) {
         if (!letters[letter] && ignore.indexOf(letter) == -1 && -1 != word.indexOf(letter, i + 1)) {
            letters[letter] = 1;
         }
      });
   });
   result = str.value.split('').filter(function (v) {
      return !letters[v];
   }).join('');

   res.value = result; //Пример: У попа была собака
}

// _______________________Task 2______________________________

let buttonHandler2 = document.querySelector('#handler2');
buttonHandler2.onclick = function (event) {
   event.preventDefault();
   let str2 = document.querySelector('#inputText2');
   let res2 = document.querySelector('#outputResult2');

   function CALCULATOR(str3) {

      var chars = str3.split("");
      var n = [], op = [], index = 0, oplast = true;

      n[index] = "";

      for (var c = 0; c < chars.length; c++) {

         if (isNaN(parseInt(chars[c])) && chars[c] !== "." && !oplast) {
            op[index] = chars[c];
            index++;
            n[index] = "";
            oplast = true;
         } else {
            n[index] += chars[c];
            oplast = false;
         }
      }

      str = parseFloat(n[0]);
      for (var o = 0; o < op.length; o++) {
         var num = parseFloat(n[o + 1]);
         switch (op[o]) {
            case "+":
               str = str + num;
               break;
            case "-":
               str = str - num;
               break;
            case "*":
               str = str * num;
               break;
            case "/":
               str = str / num;
               break;
         }
      }

      return str;
   }

   res2.value = CALCULATOR(str2.value).toFixed(2);
}

// _______________________Task 3______________________________
function Service() {

   this.el = document.getElementById('animals');
   let idNum = 3;
   let incAge = 3;

   var animals = {

      animal: [
         { id: 1, name: 'Barsik', age: 1 },
         { id: 2, name: 'Murka', age: 2 },
         { id: 6, name: 'Vasya', age: 3 }
      ]
   };

   this.Count = function (data) {
      var el = document.getElementById('counter');
      var name = 'oбъекта(ов)';

      if (data) {
         if (data > 1) {
            name = 'oбъекта(ов)';
         }
         el.innerHTML = data + ' ' + name;
      } else {
         el.innerHTML = 'Нет ' + name;
      }
   };

   this.getAll = function () {
      var data = '';

      if (animals.animal.length > 0) {
         for (i = 0; i < animals.animal.length; i++) {
            console.log(animals.animal[i]);

            data += '<tr>';
            data += '<td>' + animals.animal[i].name + '</td>';
            data += '<td><button onclick="storage.updateById(' + i + ')">Редактировать</button></td>';
            data += '<td><button onclick="storage.deleteById(' + i + ')">Удалить</button></td>';
            data += '</tr>';
         }
      }

      this.Count(animals.animal.length);
      return this.el.innerHTML = data;
   };

   this.add = function (obj) {
      el = document.getElementById('add-name');
      var country = el.value;
      obj = { id: idNum, name: country.trim(), age: incAge };

      if (country) {
         ++idNum;
         ++incAge;
         animals.animal.push(obj);
         el.value = '';
         this.getAll();
      }
   };

   this.updateById = function (item, obj) {

      var el = document.getElementById('edit-name');
      el.value = animals.animal[item].name;
      self = this;
      document.getElementById('spoiler').style.display = 'block';
      document.getElementById('saveEdit').onsubmit = function () {

         var country = el.value;
         obj = { id: idNum, name: country.trim(), age: incAge };

         if (country) {
            ++idNum;
            ++incAge;

            animals.animal.splice(item, 1, obj);
            self.getAll();
            closeInput();
         }
      }
   };

   this.deleteById = function (item) {
      console.log(item);
      animals.animal.splice(item, 1);
      this.getAll();
   };

   this.getById = function (idObj) {
      for (i = 0; i < animals.animal.length; i++) {
         if (animals.animal[i].id == idObj) {
            console.log("name: " + animals.animal[i].name + ", age: " + animals.animal[i].age);
         }
      }
   };

   this.replaceById = function (searchID) {
      var replacedObject = { id: 100, name: "trim", age: 1000 };
      for (var i = 0; i < animals.animal.length; i++) {
         if (animals.animal[i].id != searchID) continue;

         animals.animal[i].id = replacedObject.id;
         animals.animal[i].name = replacedObject.name;
         animals.animal[i].age = replacedObject.age;
         console.log(animals.animal);
         return replacedObject;
      }
   };
}

var storage = new Service();
storage.getAll();
storage.getById(6);
// storage.replaceById(1)

function closeInput() {
   document.getElementById('spoiler').style.display = 'none';
}