//Reflection 기능 사용을 위해 namesapce를 가져옴
using System.Reflection;
//일부러 큰 값을 가져오는 내용들을 추가
System.Data.DataSet ds = new();
HttpClient client = new();
//Assembly: .NET에서 컴파일된 코드의 단위, 클래스, 인터페이스, 구조체, 열거형 등과 같은 type들을 포함하는 논리적 단위
//?: null 허용 연산자, Nullable 참조 타입
Assembly? myApp = Assembly.GetEntryAssembly();
if (myApp is null) return;
//이 앱이 참조하는 모든 Assembly(라이브러리) 목록을 순회
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    //이름만 있는 Assembly 정보를 바탕으로 실제 Assembly 내용을 메모리에 로드
    Assembly a = Assembly.Load(name);
    int methodCount = 0;
    //로드된 Assembly 안에 정의된 모든 type을 순회
    foreach (TypeInfo t in a.DefinedTypes)
    {//각 type이 가지고 있는 method의 수를 누적
        methodCount += t.GetMethods().Length;
    }
    //0에 type의 수, 1에 method의 수, 2에 assembly 이름
    //N0: 숫자에 천 단위 구분 기호(,)를 포함, 소수점 이하 자릿수는 표시하지 않음
    WriteLine("{0:N0} type with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
}
