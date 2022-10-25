# Demo_OneTuchExe
[데모] 한번에 여러프로그램 실행하기!!
 

```diff
+ 데모 버젼 말고 실제로 개선하였던 프로그램이 있었는데... 소스를 잃어버렸다. 
+ 그래서 데모버젼이라도 올려둠. 나중에 필요해지면 다시 만들자!
```

목적 : 한번에 다수의 프로그램을 실행하기 위함. <br />
상황 : 출근 후 업무용 및 소스, DB Manager 같은 프로그램들을 한번에 실행<br />
    - 매일 출근시 여러프로그램 실행하는 시간을 소비하지 않아도 된다.
    
1. 프로젝트를 열고 ctrl + 실행 하면 창이 뜬다.<br />
  : 실행할 파일, 대상파일을 찾고 테스트 버튼을 클릭하면, 실행 후 json이 텍스트창에 표시된다. <br />
  : 이를 이용하여 .jsexe파일에 추가<br />
![image](https://user-images.githubusercontent.com/116536524/197698448-fdfc35b9-7eed-4705-b2ae-4445ef95ecd3.png)

2. 우측하단 [.Reg] 버튼을 클릭하여 레지스트 파일을 바탕화면에 생성<br />
![image](https://user-images.githubusercontent.com/116536524/197698580-747f4466-e5a5-4cb4-8e4c-b52bf1bc2cf9.png)

3. 생성된 레지스트 파일을 실행하여 등록.

4. 바탕화면(C:\\Users\\aseuk\\Desktop)에 "onestart.jsexe" 파일을 만들고 마우스 우측 버튼으로 클릭 시 <br />
"프로그램 목록 실행" 이란 메뉴가 추가된 것을 볼 수 있다.<br />
   : 바탕화면(C:\\Users\\aseuk\\Desktop)에 11.txt파일 하나 배치 <br />
![image](https://user-images.githubusercontent.com/116536524/197708068-39f164d3-e974-4f71-a3b5-9592a9257d93.png)


5. 파일 내용 
```json
[
  {
    "ExeFileName": "C:\\Windows\\notepad.exe",
    "TargetExeFileName": "C:\\Users\\aseuk\\Desktop\\11.txt",
    "Title": "11.txt-Windows메모장",
    "RunAs": false
  },
  {
    "ExeFileName": "C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE\\devenv.exe",
    "TargetExeFileName": "D:\\Source\\Demo_OneTuchExe\\Demo_OneTuchExe.sln",
    "Title": "Demo_OneTuchExe - Microsoft Visual Studio (관리자)",
    "RunAs": true
  }, 
  {
    "ExeFileName": "C:\\Windows\\notepad.exe",
    "TargetExeFileName": "C:\\Users\\aseuk\\Desktop\\11.txt",
    "Title": "11.txt-Windows메모장",
    "RunAs": true
  }
]
```

```diff
- Title값으로 실제 실행된 프로세스 타이틀 정보확인으로 실행여부를 확인
- Title값이 다르게 설정되면 같은 메모장이라도 실행중인 프로세스의 메인타이틀 확인 후 다르면 열림( 데모 한정 )
- 이를 이용하여 실제 프로그래밍상에서는 실행여부도 각각 보여주는 판넬도 있었으나...
```


6. "onestart.jsexe" 파일을 다시 마우스 우측버튼으로 클릭하고 "프로그램 목록 실행" 실행!!<br />
 : 첫번째 메모장이 열림 <br />
 : 두번째 비주얼스튜디오는 관리자 모드로 열림 &lt;내가 관리자모드 실행여부는 승인(클릭 또는 Enter) 해줘야 함&gt;<br />
 : 세번째 메모장은 열리지 않음(첫번째에서 열렸으므로...)<br />



