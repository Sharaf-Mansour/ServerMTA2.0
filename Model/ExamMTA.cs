using System;
using System.Collections.Generic;
using System.Linq;

namespace ServerMTA.Model
{
    public static class ExamMTA
    {
        public static List<T> For<T>(int start, int end, Func<int, T> func) => Enumerable.Range(start, end - start).Select(i => func(i)).ToList();
          public static List<Score> scores98_361 = For(1, 251, i => new Score(i));
        //  public static List<Score> scores98_361 = Foreach(Numbers, item => new Score(item));
        //  public static List<Score> scores98_361 = Enumerable.Range(1, 79).Select(i => new Score(i)).ToList();
        // public static List<TResult> Foreach<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> func) => source.Select(i => func(i)).ToList();
        //public static List<Score> scores98_361 = (from i in Enumerable.Range(1, 79) select new Score(i)).ToList();

        //public static List<Score> scores98_3611 = new () {
        //    new  (1),
        //    new  (2),
        //    new  (3),
        //    new  (4),
        //    new  (5),
        //    new  (6),
        //    new  (7),
        //    new  (8),
        //    new  (9),
        //    new  (10),
        //    new  (11),
        //    new  (12),
        //    new  (13),
        //    new  (14),
        //    new  (15),
        //    new  (16),
        //    new  (17),
        //    new  (18),
        //    new  (19),
        //    new  (20),
        //    new  (21),
        //    new  (22),
        //    new  (23),
        //    new  (24),
        //    new  (25),
        //    new  (26),
        //    new  (27),
        //    new  (28),
        //    new  (29),
        //    new  (30),
        //    new  (31),
        //    new  (32),
        //    new  (33),
        //    new  (34),
        //    new  (35),
        //    new  (36),
        //    new  (37),
        //    new  (38),
        //    new  (39),
        //    new  (40),
        //    new  (41),
        //    new  (42),
        //    new  (43),
        //    new  (44),
        //    new  (45),
        //    new  (46),
        //    new  (47),
        //    new  (48),
        //    new  (49),
        //    new  (50),
        //    new  (51),
        //    new  (52),
        //    new  (53),
        //    new  (54),
        //    new  (55),
        //    new  (56),
        //    new  (57),
        //    new  (58),
        //    new  (59),
        //    new  (60),
        //    new  (61),
        //    new  (62),
        //    new  (63),
        //    new  (64),
        //    new  (65),
        //    new  (66),
        //    new  (67),
        //    new  (68),
        //    new  (69),
        //    new  (70),
        //    new  (71),
        //    new  (72),
        //    new  (73),
        //    new  (74),
        //    new  (75),
        //    new  (76),
        //    new  (77),
        //    new  (78),
        //    new  (79)
        //};


        public static List<Exam> Exams98_361 { get; set; } = new () {
            new  (1, new () {
                new  (1, "Q1/98-361-Q1-A1.jpg", true),
                new  (2, "Q1/98-361-Q1-A2.jpg", false),
                new  (3, "Q1/98-361-Q1-A3.jpg", false),
                new  (4, "Q1/98-361-Q1-A4.jpg", false)
            }),
            new  (2, new () {
                new  (1, "Q2/98-361-Q2-A1.jpg", true),
                new  (2, "Q2/98-361-Q2-A2.jpg", false),
                new  (3, "Q2/98-361-Q2-A3.jpg", true),
                new  (4, "Q2/98-361-Q2-A4.jpg", false)
            }),
            new  (3, new () {
                new  (1, "Q3/98-361-Q3-A1.jpg", false),
                new  (2, "Q3/98-361-Q3-A2.jpg", true),
                new  (3, "Q3/98-361-Q3-A3.jpg", false),
                new  (4, "Q3/98-361-Q3-A4.jpg", false),
                new  (5, "Q3/98-361-Q3-A5.jpg", false),
                new  (6, "Q3/98-361-Q3-A6.jpg", false)
            }),
            new  (4, new () {
                new  (1, "Q4/98-361-Q4-A1.jpg", true),
                new  (2, "Q4/98-361-Q4-A2.jpg", false),
                new  (3, "Q4/98-361-Q4-A3.jpg", false),
                new  (4, "Q4/98-361-Q4-A4.jpg", false),
                new  (5, "Q4/98-361-Q4-A5.jpg", false)
            }),
            new  (5, new () {
                new  (1, "Q5/98-361-Q5-A1.jpg", false),
                new  (2, "Q5/98-361-Q5-A2.jpg", false),
                new  (3, "Q5/98-361-Q5-A3.jpg", false),
                new  (4, "Q5/98-361-Q5-A4.jpg", true)
            }),
            new  (6, new () {
                new  (1, "Q6/98-361-Q6-A1.jpg", false),
                new  (2, "Q6/98-361-Q6-A2.jpg", false),
                new  (3, "Q6/98-361-Q6-A3.jpg", true),
                new  (4, "Q6/98-361-Q6-A4.jpg", false)
            }),
            new  (7, new () {
                new  (1, "Q7/98-361-Q7-A1.jpg", true),
                new  (2, "Q7/98-361-Q7-A2.jpg", false),
                new  (3, "Q7/98-361-Q7-A3.jpg", false),
                new  (4, "Q7/98-361-Q7-A4.jpg", false)
            }),
            new  (8, new () {
                new  (1, "Q8/98-361-Q8-A1.jpg", false),
                new  (2, "Q8/98-361-Q8-A2.jpg", false),
                new  (3, "Q8/98-361-Q8-A3.jpg", false),
                new  (4, "Q8/98-361-Q8-A4.jpg", true)
            }),
            new  (9, new () {
                new  (1, "Q9/98-361-Q9-A1.jpg", true),
                new  (2, "Q9/98-361-Q9-A2.jpg", false),
                new  (3, "Q9/98-361-Q9-A3.jpg", false),
                new  (4, "Q9/98-361-Q9-A4.jpg", false)
            }),
            new  (10, new () {
                new  (1, "Q10/98-361-Q10-A1.jpg", false),
                new  (2, "Q10/98-361-Q10-A2.jpg", true),
                new  (3, "Q10/98-361-Q10-A3.jpg", false),
                new  (4, "Q10/98-361-Q10-A4.jpg", false)
            }),
            new  (11, new () {
                new  (1, "Q11/98-361-Q11-A1.jpg", false),
                new  (2, "Q11/98-361-Q11-A2.jpg", false),
                new  (3, "Q11/98-361-Q11-A3.jpg", false),
                new  (4, "Q11/98-361-Q11-A4.jpg", true)
            }),
            new  (12, new () {
                new  (1, "Q12/98-361-Q12-A1.jpg", false),
                new  (2, "Q12/98-361-Q12-A2.jpg", true),
                new  (3, "Q12/98-361-Q12-A3.jpg", false),
                new  (4, "Q12/98-361-Q12-A4.jpg", false)
            }),
            new  (13, new () {
                new  (1, "Q13/98-361-Q13-A1.jpg", true),
                new  (2, "Q13/98-361-Q13-A2.jpg", false),
                new  (3, "Q13/98-361-Q13-A3.jpg", false),
                new  (4, "Q13/98-361-Q13-A4.jpg", false)
            }),
            new  (14, new () {
                new  (1, "Q14/98-361-Q14-A1.jpg", false),
                new  (2, "Q14/98-361-Q14-A2.jpg", true),
                new  (3, "Q14/98-361-Q14-A3.jpg", false),
                new  (4, "Q14/98-361-Q14-A4.jpg", false)
            }),
            new  (15, new () {
                new  (1, "Q15/98-361-Q15-A1.jpg", true),
                new  (2, "Q15/98-361-Q15-A2.jpg", false),
                new  (3, "Q15/98-361-Q15-A3.jpg", false),
                new  (4, "Q15/98-361-Q15-A4.jpg", false)
            }),
            new  (16, new () {
                new  (1, "Q16/98-361-Q16-A1.jpg", true),
                new  (2, "Q16/98-361-Q16-A2.jpg", false),
                new  (3, "Q16/98-361-Q16-A3.jpg", false),
                new  (4, "Q16/98-361-Q16-A4.jpg", false)
            }),
            new  (17, new () {
                new  (1, "Q17/98-361-Q17-A1.jpg", false),
                new  (2, "Q17/98-361-Q17-A2.jpg", false),
                new  (3, "Q17/98-361-Q17-A3.jpg", false),
                new  (4, "Q17/98-361-Q17-A4.jpg", true)
            }),
            new  (18, new () {
                new  (1, "Q18/98-361-Q18-A1.jpg", true),
                new  (2, "Q18/98-361-Q18-A2.jpg", false),
                new  (3, "Q18/98-361-Q18-A3.jpg", false),
                new  (4, "Q18/98-361-Q18-A4.jpg", false)
            }),
            new  (19, new () {
                new  (1, "Q19/98-361-Q19-A1.jpg", false),
                new  (2, "Q19/98-361-Q19-A2.jpg", true),
                new  (3, "Q19/98-361-Q19-A3.jpg", false),
                new  (4, "Q19/98-361-Q19-A4.jpg", false)
            }),
            new  (20, new () {
                new  (1, "Q20/98-361-Q20-A1.jpg", true),
                new  (2, "Q20/98-361-Q20-A2.jpg", false),
                new  (3, "Q20/98-361-Q20-A3.jpg", false),
                new  (4, "Q20/98-361-Q20-A4.jpg", false)
            }),
            new  (21, new () {
                new  (1, "Q21/98-361-Q21-A1.jpg", true),
                new  (2, "Q21/98-361-Q21-A2.jpg", false),
                new  (3, "Q21/98-361-Q21-A3.jpg", false),
                new  (4, "Q21/98-361-Q21-A4.jpg", false)
            }),
            new  (22, new () {
                new  (1, "Q22/98-361-Q22-A1.jpg", true),
                new  (2, "Q22/98-361-Q22-A2.jpg", false),
                new  (3, "Q22/98-361-Q22-A3.jpg", false),
                new  (4, "Q22/98-361-Q22-A4.jpg", false)
            }),
            new  (23, new () {
                new  (1, "Q23/98-361-Q23-A1.jpg", false),
                new  (2, "Q23/98-361-Q23-A2.jpg", false),
                new  (3, "Q23/98-361-Q23-A3.jpg", false),
                new  (4, "Q23/98-361-Q23-A4.jpg", true)
            }),
            new  (24, new () {
                new  (1, "Q24/98-361-Q24-A1.jpg", true),
                new  (2, "Q24/98-361-Q24-A2.jpg", false),
                new  (3, "Q24/98-361-Q24-A3.jpg", false),
                new  (4, "Q24/98-361-Q24-A4.jpg", false)
            }),
            new  (25, new () {
                new  (1, "Q25/98-361-Q25-A1.jpg", false),
                new  (2, "Q25/98-361-Q25-A2.jpg", false),
                new  (3, "Q25/98-361-Q25-A3.jpg", true),
                new  (4, "Q25/98-361-Q25-A4.jpg", false)
            }),
            new  (26, new () {
                new  (1, "Q26/98-361-Q26-A1.jpg", false),
                new  (2, "Q26/98-361-Q26-A2.jpg", false),
                new  (3, "Q26/98-361-Q26-A3.jpg", false),
                new  (4, "Q26/98-361-Q26-A4.jpg", true)
            }),
            new  (27, new () {
                new  (1, "Q27/98-361-Q27-A1.jpg", false),
                new  (2, "Q27/98-361-Q27-A2.jpg", false),
                new  (3, "Q27/98-361-Q27-A3.jpg", false),
                new  (4, "Q27/98-361-Q27-A4.jpg", true)
            }),
            new  (28, new () {
                new  (1, "Q28/98-361-Q28-A1.jpg", true),
                new  (2, "Q28/98-361-Q28-A2.jpg", false),
                new  (3, "Q28/98-361-Q28-A3.jpg", false),
                new  (4, "Q28/98-361-Q28-A4.jpg", false)
            }),
            new  (29, new () {
                new  (1, "Q29/98-361-Q29-A1.jpg", true),
                new  (2, "Q29/98-361-Q29-A2.jpg", true),
                new  (3, "Q29/98-361-Q29-A3.jpg", false),
                new  (4, "Q29/98-361-Q29-A4.jpg", false)
            }),
            new  (30, new () {
                new  (1, "Q30/98-361-Q30-A1.jpg", false),
                new  (2, "Q30/98-361-Q30-A2.jpg", true),
                new  (3, "Q30/98-361-Q30-A3.jpg", false),
                new  (4, "Q30/98-361-Q30-A4.jpg", false)
            }),
            new  (31, new () {
                new  (1, "Q31/98-361-Q31-A1.jpg", false),
                new  (2, "Q31/98-361-Q31-A2.jpg", false),
                new  (3, "Q31/98-361-Q31-A3.jpg", false),
                new  (4, "Q31/98-361-Q31-A4.jpg", true)
            }),
            new  (32, new () {
                new  (1, "Q32/98-361-Q32-A1.jpg", true),
                new  (2, "Q32/98-361-Q32-A2.jpg", false),
                new  (3, "Q32/98-361-Q32-A3.jpg", false),
                new  (4, "Q32/98-361-Q32-A4.jpg", false)
            }),
            new  (33, new () {
                new  (1, "Q33/98-361-Q33-A1.jpg", false),
                new  (2, "Q33/98-361-Q33-A2.jpg", true),
                new  (3, "Q33/98-361-Q33-A3.jpg", false),
                new  (4, "Q33/98-361-Q33-A4.jpg", false)
            }),
            new  (34, new () {
                new  (1, "Q34/98-361-Q34-A1.jpg", false),
                new  (2, "Q34/98-361-Q34-A2.jpg", false),
                new  (3, "Q34/98-361-Q34-A3.jpg", false),
                new  (4, "Q34/98-361-Q34-A4.jpg", true)
            }),
            new  (35, new () {
                new  (1, "Q35/98-361-Q35-A1.jpg", false),
                new  (2, "Q35/98-361-Q35-A2.jpg", true),
                new  (3, "Q35/98-361-Q35-A3.jpg", false),
                new  (4, "Q35/98-361-Q35-A4.jpg", true)
            }),
            new  (36, new () {
                new  (1, "Q36/98-361-Q36-A1.jpg", true),
                new  (2, "Q36/98-361-Q36-A2.jpg", false),
                new  (3, "Q36/98-361-Q36-A3.jpg", true),
                new  (4, "Q36/98-361-Q36-A4.jpg", false)
            }),
            new  (37, new () {
                new  (1, "Q37/98-361-Q37-A1.jpg", false),
                new  (2, "Q37/98-361-Q37-A2.jpg", true),
                new  (3, "Q37/98-361-Q37-A3.jpg", false),
                new  (4, "Q37/98-361-Q37-A4.jpg", false)
            }),
            new  (38, new () {
                new  (1, "Q38/98-361-Q38-A1.jpg", false),
                new  (2, "Q38/98-361-Q38-A2.jpg", false),
                new  (3, "Q38/98-361-Q38-A3.jpg", true),
                new  (4, "Q38/98-361-Q38-A4.jpg", false)
            }),
            new  (39, new () {
                new  (1, "Q39/98-361-Q39-A1.jpg", true),
                new  (2, "Q39/98-361-Q39-A2.jpg", false),
                new  (3, "Q39/98-361-Q39-A3.jpg", false),
                new  (4, "Q39/98-361-Q39-A4.jpg", false)
            }),
            new  (40, new () {
                new  (1, "Q40/98-361-Q40-A1.jpg", false),
                new  (2, "Q40/98-361-Q40-A2.jpg", false),
                new  (3, "Q40/98-361-Q40-A3.jpg", true),
                new  (4, "Q40/98-361-Q40-A4.jpg", false)
            }),
            new  (41, new () {
                new  (1, "Q41/98-361-Q41-A1.jpg", false),
                new  (2, "Q41/98-361-Q41-A2.jpg", true),
                new  (3, "Q41/98-361-Q41-A3.jpg", false),
                new  (4, "Q41/98-361-Q41-A4.jpg", false)
            }),
            new  (42, new () {
                new  (1, "Q42/98-361-Q42-A1.jpg", true),
                new  (2, "Q42/98-361-Q42-A2.jpg", false),
                new  (3, "Q42/98-361-Q42-A3.jpg", false),
                new  (4, "Q42/98-361-Q42-A4.jpg", false)
            }),
            new  (43, new () {
                new  (1, "Q43/98-361-Q43-A1.jpg", false),
                new  (2, "Q43/98-361-Q43-A2.jpg", true),
                new  (3, "Q43/98-361-Q43-A3.jpg", false),
                new  (4, "Q43/98-361-Q43-A4.jpg", false)
            }),
            new  (44, new () {
                new  (1, "Q44/98-361-Q44-A1.jpg", true),
                new  (2, "Q44/98-361-Q44-A2.jpg", false),
                new  (3, "Q44/98-361-Q44-A3.jpg", false),
                new  (4, "Q44/98-361-Q44-A4.jpg", false)
            }),
            new  (45, new () {
                new  (1, "Q45/98-361-Q45-A1.jpg", true),
                new  (2, "Q45/98-361-Q45-A2.jpg", false),
                new  (3, "Q45/98-361-Q45-A3.jpg", false),
                new  (4, "Q45/98-361-Q45-A4.jpg", false)
            }),
            new  (46, new () {
                new  (1, "Q46/98-361-Q46-A1.jpg", true),
                new  (2, "Q46/98-361-Q46-A2.jpg", false),
                new  (3, "Q46/98-361-Q46-A3.jpg", false),
                new  (4, "Q46/98-361-Q46-A4.jpg", false)
            }),
            new  (47, new () {
                new  (1, "Q47/98-361-Q47-A1.jpg", false),
                new  (2, "Q47/98-361-Q47-A2.jpg", true),
                new  (3, "Q47/98-361-Q47-A3.jpg", false),
                new  (4, "Q47/98-361-Q47-A4.jpg", false)
            }),
            new  (48, new () {
                new  (1, "Q48/98-361-Q48-A1.jpg", true),
                new  (2, "Q48/98-361-Q48-A2.jpg", false),
                new  (3, "Q48/98-361-Q48-A3.jpg", true),
                new  (4, "Q48/98-361-Q48-A4.jpg", false)
            }),
            new  (49, new () {
                new  (1, "Q49/98-361-Q49-A1.jpg", false),
                new  (2, "Q49/98-361-Q49-A2.jpg", true),
                new  (3, "Q49/98-361-Q49-A3.jpg", false),
                new  (4, "Q49/98-361-Q49-A4.jpg", true)
            }),
            new  (50, new () {
                new  (1, "Q50/98-361-Q50-A1.jpg", true),
                new  (2, "Q50/98-361-Q50-A2.jpg", false),
                new  (3, "Q50/98-361-Q50-A3.jpg", false),
                new  (4, "Q50/98-361-Q50-A4.jpg", false)
            }),
            new  (51, new () {
                new  (1, "Q51/98-361-Q51-A1.jpg", false),
                new  (2, "Q51/98-361-Q51-A2.jpg", false),
                new  (3, "Q51/98-361-Q51-A3.jpg", true),
                new  (4, "Q51/98-361-Q51-A4.jpg", false)
            }),
            new  (52, new () {
                new  (1, "Q52/98-361-Q52-A1.jpg", false),
                new  (2, "Q52/98-361-Q52-A2.jpg", false),
                new  (3, "Q52/98-361-Q52-A3.jpg", false),
                new  (4, "Q52/98-361-Q52-A4.jpg", true)
            }),
            new  (53, new () {
                new  (1, "Q53/98-361-Q53-A1.jpg", true),
                new  (2, "Q53/98-361-Q53-A2.jpg", false),
                new  (3, "Q53/98-361-Q53-A3.jpg", true),
                new  (4, "Q53/98-361-Q53-A4.jpg", false)
            }),
            new  (54, new () {
                new  (1, "Q54/98-361-Q54-A1.jpg", true),
                new  (2, "Q54/98-361-Q54-A2.jpg", false),
                new  (3, "Q54/98-361-Q54-A3.jpg", false),
                new  (4, "Q54/98-361-Q54-A4.jpg", false)
            }),
            new  (55, new () {
                new  (1, "Q55/98-361-Q55-A1.jpg", false),
                new  (2, "Q55/98-361-Q55-A2.jpg", false),
                new  (3, "Q55/98-361-Q55-A3.jpg", false),
                new  (4, "Q55/98-361-Q55-A4.jpg", true)
            }),
            new  (56, new () {
                new  (1, "Q56/98-361-Q56-A1.jpg", true),
                new  (2, "Q56/98-361-Q56-A2.jpg", false),
                new  (3, "Q56/98-361-Q56-A3.jpg", false),
                new  (4, "Q56/98-361-Q56-A4.jpg", false)
            }),
            new  (57, new () {
                new  (1, "Q57/98-361-Q57-A1.jpg", true),
                new  (2, "Q57/98-361-Q57-A2.jpg", false),
                new  (3, "Q57/98-361-Q57-A3.jpg", false),
                new  (4, "Q57/98-361-Q57-A4.jpg", false)
            }),
            new  (58, new () {
                new  (1, "Q58/98-361-Q58-A1.jpg", true),
                new  (2, "Q58/98-361-Q58-A2.jpg", false),
                new  (3, "Q58/98-361-Q58-A3.jpg", false),
                new  (4, "Q58/98-361-Q58-A4.jpg", false)
            }),
            new  (59, new () {
                new  (1, "Q59/98-361-Q59-A1.jpg", false),
                new  (2, "Q59/98-361-Q59-A2.jpg", false),
                new  (3, "Q59/98-361-Q59-A3.jpg", false),
                new  (4, "Q59/98-361-Q59-A4.jpg", true)
            }),
            new  (60, new () {
                new  (1, "Q60/98-361-Q60-A1.jpg", false),
                new  (2, "Q60/98-361-Q60-A2.jpg", true),
                new  (3, "Q60/98-361-Q60-A3.jpg", false),
                new  (4, "Q60/98-361-Q60-A4.jpg", false)
            }),
            new  (61, new () {
                new  (1, "Q61/98-361-Q61-A1.jpg", true),
                new  (2, "Q61/98-361-Q61-A2.jpg", false),
                new  (3, "Q61/98-361-Q61-A3.jpg", false),
                new  (4, "Q61/98-361-Q61-A4.jpg", false)
            }),
            new  (62, new () {
                new  (1, "Q62/98-361-Q62-A1.jpg", true),
                new  (2, "Q62/98-361-Q62-A2.jpg", false),
                new  (3, "Q62/98-361-Q62-A3.jpg", false),
                new  (4, "Q62/98-361-Q62-A4.jpg", false)
            }),
            new  (63, new () {
                new  (1, "Q63/98-361-Q63-A1.jpg", false),
                new  (2, "Q63/98-361-Q63-A2.jpg", true),
                new  (3, "Q63/98-361-Q63-A3.jpg", false),
                new  (4, "Q63/98-361-Q63-A4.jpg", false)
            }),
            new  (64, new () {
                new  (1, "Q64/98-361-Q64-A1.jpg", true),
                new  (2, "Q64/98-361-Q64-A2.jpg", false),
                new  (3, "Q64/98-361-Q64-A3.jpg", false),
                new  (4, "Q64/98-361-Q64-A4.jpg", false)
            }),
            new  (65, new () {
                new  (1, "Q65/98-361-Q65-A1.jpg", false),
                new  (2, "Q65/98-361-Q65-A2.jpg", false),
                new  (3, "Q65/98-361-Q65-A3.jpg", false),
                new  (4, "Q65/98-361-Q65-A4.jpg", true)
            }),
            new  (66, new () {
                new  (1, "Q66/98-361-Q66-A1.jpg", true),
                new  (2, "Q66/98-361-Q66-A2.jpg", false),
                new  (3, "Q66/98-361-Q66-A3.jpg", false),
                new  (4, "Q66/98-361-Q66-A4.jpg", false)
            }),
            new  (67, new () {
                new  (1, "Q67/98-361-Q67-A1.jpg", true),
                new  (2, "Q67/98-361-Q67-A2.jpg", false),
                new  (3, "Q67/98-361-Q67-A3.jpg", false),
                new  (4, "Q67/98-361-Q67-A4.jpg", false)
            }),
            new  (68, new () {
                new  (1, "Q68/98-361-Q68-A1.jpg", true),
                new  (2, "Q68/98-361-Q68-A2.jpg", false),
                new  (3, "Q68/98-361-Q68-A3.jpg", false),
                new  (4, "Q68/98-361-Q68-A4.jpg", false)
            }),
            new  (69, new () {
                new  (1, "Q69/98-361-Q69-A1.jpg", true),
                new  (2, "Q69/98-361-Q69-A2.jpg", false),
                new  (3, "Q69/98-361-Q69-A3.jpg", false),
                new  (4, "Q69/98-361-Q69-A4.jpg", false)
            }),
            new  (70, new () {
                new  (1, "Q70/98-361-Q70-A1.jpg", false),
                new  (2, "Q70/98-361-Q70-A2.jpg", false),
                new  (3, "Q70/98-361-Q70-A3.jpg", false),
                new  (4, "Q70/98-361-Q70-A4.jpg", true)
            }),
            new  (71, new () {
                new  (1, "Q71/98-361-Q71-A1.jpg", true),
                new  (2, "Q71/98-361-Q71-A2.jpg", false),
                new  (3, "Q71/98-361-Q71-A3.jpg", false),
                new  (4, "Q71/98-361-Q71-A4.jpg", false)
            }),
            new  (72, new () {
                new  (1, "Q72/98-361-Q72-A1.jpg", false),
                new  (2, "Q72/98-361-Q72-A2.jpg", false),
                new  (3, "Q72/98-361-Q72-A3.jpg", true),
                new  (4, "Q72/98-361-Q72-A4.jpg", false)
            }),
            new  (73, new () {
                new  (1, "Q73/98-361-Q73-A1.jpg", false),
                new  (2, "Q73/98-361-Q73-A2.jpg", true),
                new  (3, "Q73/98-361-Q73-A3.jpg", false),
                new  (4, "Q73/98-361-Q73-A4.jpg", false)
            }),
            new  (74, new () {
                new  (1, "Q74/98-361-Q74-A1.jpg", false),
                new  (2, "Q74/98-361-Q74-A2.jpg", true),
                new  (3, "Q74/98-361-Q74-A3.jpg", false),
                new  (4, "Q74/98-361-Q74-A4.jpg", false)
            }),
            new  (75, new () {
                new  (1, "Q75/98-361-Q75-A1.jpg", false),
                new  (2, "Q75/98-361-Q75-A2.jpg", false),
                new  (3, "Q75/98-361-Q75-A3.jpg", false),
                new  (4, "Q75/98-361-Q75-A4.jpg", true)
            }),
            new  (76, new () {
                new  (1, "Q76/98-361-Q76-A1.jpg", false),
                new  (2, "Q76/98-361-Q76-A2.jpg", true),
                new  (3, "Q76/98-361-Q76-A3.jpg", false),
                new  (4, "Q76/98-361-Q76-A4.jpg", false)
            }),
            new  (77, new () {
                new  (1, "Q77/98-361-Q77-A1.jpg", false),
                new  (2, "Q77/98-361-Q77-A2.jpg", false),
                new  (3, "Q77/98-361-Q77-A3.jpg", true),
                new  (4, "Q77/98-361-Q77-A4.jpg", false)
            }),
            new  (78, new () {
                new  (1, "Q78/98-361-Q78-A1.jpg", true),
                new  (2, "Q78/98-361-Q78-A2.jpg", false),
                new  (3, "Q78/98-361-Q78-A3.jpg", false),
                new  (4, "Q78/98-361-Q78-A4.jpg", false)
            }),
            new  (79, new () {
                new  (1, "Q79/98-361-Q79-A1.jpg", true),
                new  (2, "Q79/98-361-Q79-A2.jpg", false),
                new  (3, "Q79/98-361-Q79-A3.jpg", true),
                new  (4, "Q79/98-361-Q79-A4.jpg", false)
            }),
        };
    }
}