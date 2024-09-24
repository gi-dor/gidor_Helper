<h2 align="center"> [ gidor_Helper ] </h2>

<br>

> 반복되는 업무 자동화 프로그램  
> 복잡한 데이터베이스 테이블 간의 관계를 효율적으로 관리하고,  
> 매번 수동으로 입력해야 했던 쿼리를 자동화하여 작업을 간소화

---


## 프로젝트 개요

**gidor_Helper**는 실제 업무에서 자주 사용되는 작업을 자동화하기 위해 개발된 프로그램입니다.  
회사 DB는 2005년 이전부터 사용된 오래된 시스템으로, 테이블 이름이 `LS + 숫자` 로  알아보기 어렵고 복잡한 구조를 가지고 있습니다.

업무를 함에 있어 매번 테이블을 상세히 확인하며 `SQL 쿼리를 수동으로 작성해` 진행했고  

이러한 반복적인 작업이 매일 여러건으로 발생되었기에 자동화하여 더 효율적인 작업 환경을 위함과 

동시에 회사 언어와 도구인 winform 과 C#에 익숙해지기 위해 프로젝트를 시작했습니다.

---


<br>

## 🐥 목차
- [⚙ 기술 스택](#기술-스택)
- [💻 기능 구현](#기능-구현)
- [🔥 개선 사항](#개선-사항)
<br>
<br>


## ⚙ 기술 스택 <a name="기술-스택"></a>


| 분류       | 기술명                                                   |
|----------|------------------------------------------------------------|
| BackEnd  | C#  ,   .NET Framework                                        |
| FrontEnd | WinForms                                                   |
| DataBase | MSSQL                                                      |
| Version Control    | GitHub                                           |
| Tools    |  Visual Studio                                             |


<br>

## 💻 기능구현 <a name="기능-구현"></a>


- 사용자 아이디 조회 , 부분조회
- 공통코드 조회 , 부분조회 
- 운송장 스캔 정보 조회 및 세부 정보 조회 , 수정 , 삭제 

<br>

## 🔥 개선사항 <a name="개선-사항"></a><br>


### 반복되는 DB연결정보 함수화 

- 반복되어 사용되는 DB연결정보를 DB_Info 클래스를 생성해 해당 포트 연결에 맞게 DB설정 이후 메서드 호출로 사용했습니다
- [ [코드](https://github.com/gi-dor/gidor_Helper/blob/5a8ba8978fb544ba4382134dede21e15ef41b6e7/Util/DB_Info.cs#L12-L34) ]
	

###  SQL 쿼리 구성 최적화

- WHERE 절 구성을 위해 기존 리스트 사용을 제거하고, 조건을 직접 평가하는 방식으로 쿼리 생성 로직을 리팩토링을 진행했습니다
- 여러 텍스트 박스 입력을 처리 할때 `Boolean` 변수에 담아 사용하여 코드의 가독성과 유지 보수성을 향상 시켰습니다
- [ [변경전](https://github.com/gi-dor/gidor_Helper/blob/b15e90c70c555c350960b9753b32e4d817a2e8ba/domain/User/IdManage.cs#L286-L313) ]
- [ [변경후](https://github.com/gi-dor/gidor_Helper/blob/b15e90c70c555c350960b9753b32e4d817a2e8ba/domain/User/IdManage.cs#L154-L222) ]
