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
- [📌 문제 해결](#문제-해결)

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



## 📌 트러블슈팅<a name="트러블슈팅"></a>

###  운송장상태 페이지 조회 SQL 쿼리 성능,기능문제

- 상황 
> MSSQL 데이터베이스에서 `A.SCANN_TIME` 컬럼에 인덱스가 존재하지 않아 해당 컬럼을 포함한 정렬인 
>`ORDER BY A.SCANN_DATE DESC , A.SCANN_TIME DESC`를 수행시
> 조회 시간이 과도하게 증가해 시간 초과로인한 조회 기능 종료 

- 문제점
> SCANN_TIME 컬럼에 대해 인덱스가 없으며 회사내에 데이터베이스이기에 함부로 인덱스를 추가 할수 없는 상황

- 해결

1. `SCANN_DATE DESC` 을 사용해 우선적으로 정렬후 C#의 DataView.Sort 메서드를 사용해 SCANN_TIME 기준으로 추가적인 정렬을 실행했습니다
2. MSSQL에서 다룰수 없는 컬럼에 대한 데이터 정렬을 C# 코드에서 정렬하는 방법은 메모리에서 수행되는 정렬이기에 인덱스의 영향을 받지 않습니다
3. 다만 , 메모리에서 불러오는 데이터가 많다면 프로그램에 성능에 영향을 줄수 있다 , 인덱스를 사용한 정렬하는것보다 성능이 떨어질 수 있습니다
4. 인덱스를 추가할 수 없기에 C#에서 정렬한 방법은 덜 최적화된 방법이지만 데이터정렬을 위한 또다른 방법입니다

```
String sqlQuery = "SELECT top 100000 " +
                    " A.INV_NO       as '송장번호'   ," +
                    " A.BRA_ID       as '영업소'   , " +
                    " A.SCANN_SLT    as '스캔 상태'   , " +
                    " B.COD_CONT     as '코드 내용'   , " +
                    " A.SCANN_DATE   as '스캔 일자'  , " +
                    " A.SCANN_TIME   as '스캔 시간'   , " +
                    " A.CAR_ID       as '배송 차량'   , " +
                    " A.SCANN_USR_ID as '스캔 ID'   , " +
                    " A.TRS_ID       as '처리자 ID'   , " +
                    " A.TRS_NAME     as '처리자 명'   , " +
                    " A.TRS_DATE     as '처리 일자'" +
                    " FROM SLIS_MASTER.dbo.LS101T0 A " +
                    " INNER JOIN SLIS_MASTER.dbo.LS901T0 B " +
                    " ON A.SCANN_SLT = B.COD " +
                    " ORDER BY A.SCANN_DATE DESC ";


                         ..... 생략       


                    DataView dataView = dataTable.DefaultView;
                    dataView.Sort = " 스캔 시간 DESC ";
                    ScanDataGridView1.DataSource = dataView.ToTable();
```