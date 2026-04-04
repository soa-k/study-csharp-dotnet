///Vocabulary에서 Remove or Include한 내용이 제대로 작동되는지 확인
//(1) System.Console.WriteLine이 아닌 WriteLine으로 바로 사용
//(2) System.Environment.MachineName이 아닌 Env.MachineName으로 바로 사용
//(3) $로 변수를 문자열에 + 없이 바로 연결하여 사용
//(4) \"로 문자열 안에 "를 출력
WriteLine($"Computer named {Env.MachineName} says \"NO.\"");
//method는 동사의 역할, WriteLine은 Console의 method
//type은 명사의 역할, string과 int는 type이지만 Alias(별칭)일 뿐 진짜 이름이 아님
//type의 진짜 이름(FullName)은 namespace와 type이름을 포함한 전체 이름(System.String, System.Int32)
//int, string, double 등은 Primitive type(기본 자료형)이라고도 불림
//모든 class는 type이지만 모든 type이 class는 아님(구조체, 열거형 등 존재)
//Value(값) Type: int, double, bool 등(구조체) / Reference(참조) Type: string, object, class 등(클래스)
WriteLine(typeof( string ).FullName);
WriteLine(typeof( int ).FullName);