using UnityEngine;

public interface ICommand
{
    void Execute();
}

// 여러 개의 스킬을 사용할 수 있고 퀵슬롯으로 등록해 사용하는 방식을 디자인 패턴을 적용시켜서 구현해보면
// '커맨드 패턴'을 사용해 호출자와 사용 객체를 분리해서 다양한 스킬을 등록하고 실행시킬 수 있는 퀵슬롯을 구현할 수 있습니다.

